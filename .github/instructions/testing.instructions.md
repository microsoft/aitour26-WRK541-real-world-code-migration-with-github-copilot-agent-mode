---
description: "Use when running pytest, dotnet test, parity validation, regression checks, debugging failing tests, or comparing Python and C# behavior."
name: "Testing and Parity Validation"
---

# Testing Rules

- Run the smallest relevant test set first, then broaden scope.
- Prefer reproducing failures with a single endpoint before changing code.
- Report exact failing commands and summarize the failure reason in plain language.
- If C# behavior intentionally differs, call it out explicitly instead of silently adapting tests.
- Do not mark a migration step complete without at least one concrete validation step.
