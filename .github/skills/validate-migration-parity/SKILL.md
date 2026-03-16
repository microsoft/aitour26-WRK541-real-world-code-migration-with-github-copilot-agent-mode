---
name: validate-migration-parity
description: 'Validate parity between the Python API and the C# rewrite. Use for pytest, dotnet build, dotnet test, endpoint comparison, regression checks, and follow-up recommendations.'
argument-hint: 'Endpoint, test name, or validation scope'
user-invocable: true
---

# Validate Migration Parity

## When to Use
- After implementing a new endpoint
- When a Python test fails against the C# rewrite
- When checking whether a migration step is complete
- When summarizing regressions or confirming parity

## Procedure
1. Identify the smallest relevant validation scope.
2. Run the narrowest useful command first.
3. If needed, use [verify-endpoints.sh](./scripts/verify-endpoints.sh) as a starting point for manual endpoint checks.
4. Compare the C# behavior with the Python baseline.
5. Report pass/fail results and the likely cause of mismatches.

## Rules
- Prefer small validation loops over all-at-once test runs.
- Report exact commands that were run.
- Separate build failures, test failures, and behavior mismatches.
- Do not silently reinterpret mismatches as acceptable.

## Output
- Commands run
- Passing checks
- Failing checks
- Likely cause
- Recommended next action
