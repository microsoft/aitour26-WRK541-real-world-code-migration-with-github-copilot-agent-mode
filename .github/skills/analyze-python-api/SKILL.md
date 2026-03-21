---
name: analyze-python-api
description: 'Analyze the Python weather API, tests, endpoint behavior, and migration scope. Use for extracting routes, payloads, and validation points before C# implementation.'
argument-hint: 'Target file or scope to analyze'
user-invocable: true
---

# Analyze Python API

## When to Use
- Before implementing a new C# endpoint
- When tests fail and Python behavior must be confirmed
- When creating a migration plan
- When comparing Python behavior with the C# rewrite

## Procedure
1. Read `src/python-app/webapp/main.py`.
2. Read `src/python-app/webapp/test_main.py`.
3. Identify all routes, parameters, response shapes, and error cases.
4. Cross-check what behavior is explicitly covered by tests.
5. Produce the summary using the format in [output-format](./references/output-format.md).

## Rules
- Treat the Python implementation as the behavioral source of truth.
- Separate confirmed behavior from assumptions.
- Prefer endpoint-by-endpoint summaries over high-level generalizations.
- If behavior is unclear, point to the exact file and function that needs review.

## Output
- Endpoint inventory
- Response expectations
- Test coverage notes
- Recommended migration order
