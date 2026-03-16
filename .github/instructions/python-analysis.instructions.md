---
description: "Use when analyzing the Python source, FastAPI endpoints, test_main.py, API behavior, response payloads, or migration parity from Python to C#."
name: "Python API Analysis"
applyTo: "src/python-app/**/*.py"
---

# Python API Analysis Rules

- Treat the Python implementation as the behavioral source of truth.
- Extract routes, query/path parameters, response shapes, and error behavior before proposing C# changes.
- Read `test_main.py` before suggesting implementation order.
- Separate confirmed behavior from assumptions in summaries.
- If behavior is unclear, point to the exact Python file and function that needs review.
