"""Simple link checker for Markdown files in the repo.

- Scans .md files under repo root and docs/
- Validates local relative links (./, ../)
- Performs HTTP HEAD (fallback to GET) for external http(s) links with 10s timeout

Outputs a brief report to stdout and returns non-zero if broken links found.
"""
import re
import os
import sys
import requests
from urllib.parse import urljoin, urlparse

ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), '..', '..'))

md_paths = []
for dirpath, dirnames, filenames in os.walk(ROOT):
    # skip common binary/venv folders
    if any(skip in dirpath for skip in ['.git', 'site', 'bin', 'obj', 'node_modules']):
        continue
    for f in filenames:
        if f.lower().endswith('.md'):
            md_paths.append(os.path.join(dirpath, f))

link_re = re.compile(r"\[([^\]]*)\]\(([^)]+)\)")

errors = []
checked = 0

session = requests.Session()
session.headers.update({'User-Agent': 'aitour-link-checker/1.0'})

for md in md_paths:
    rel_md = os.path.relpath(md, ROOT)
    with open(md, 'r', encoding='utf-8') as fh:
        lines = fh.readlines()
    for i, line in enumerate(lines, start=1):
        for m in link_re.finditer(line):
            text, url = m.group(1).strip(), m.group(2).strip()
            checked += 1
            if url.startswith('http://') or url.startswith('https://'):
                try:
                    # HEAD first
                    r = session.head(url, allow_redirects=True, timeout=10)
                    status = r.status_code
                    final = r.url
                except Exception as e:
                    try:
                        r = session.get(url, allow_redirects=True, timeout=10)
                        status = r.status_code
                        final = r.url
                    except Exception as e2:
                        errors.append((rel_md, i, url, 'network', str(e2)))
                        continue
                if status >= 400:
                    errors.append((rel_md, i, url, 'http', status))
            elif url.startswith('mailto:'):
                # don't check mailto
                continue
            elif url.startswith('#'):
                # anchor link, skip
                continue
            else:
                # relative link; resolve against this file's directory
                target = os.path.normpath(os.path.join(os.path.dirname(md), url))
                # if link has a fragment, strip it
                if '#' in target:
                    target = target.split('#')[0]
                if not os.path.exists(target):
                    errors.append((rel_md, i, url, 'local-missing', target))

# Print report
print(f"Checked {checked} links across {len(md_paths)} markdown files")
if errors:
    print(f"Found {len(errors)} problems:")
    for e in errors:
        print(e)
    sys.exit(2)
else:
    print("No broken links found (local existence + HTTP status < 400).")
    sys.exit(0)
