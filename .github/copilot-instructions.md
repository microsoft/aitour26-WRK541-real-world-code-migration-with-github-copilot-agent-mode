# WRK541 Project Guidelines

## Goal
- Migrate the Python weather API to C# .NET Minimal APIs while preserving behavior.
- Treat the Python implementation and its tests as the functional baseline.

## Build and Test
- Python app tests: `cd src/python-app/webapp && pytest -q`
- C# build: `cd src/csharp-app && dotnet build`
- C# tests: `cd src/csharp-app/WeatherService.UnitTests && dotnet test`
- Docs build: `cd docs && mkdocs build`

## Implementation Rules
- Prefer small, incremental changes.
- Add or modify one endpoint at a time and validate immediately.
- Keep JSON handling on the C# side with `System.Text.Json` unless a strong reason exists.
- Preserve endpoint names, routes, and response behavior unless the task explicitly changes them.
- Do not rewrite unrelated files while implementing migration steps.

## Verification Rules
- Before claiming completion, explain what was validated.
- When tests fail, identify whether the issue is in Python parity, C# implementation, or test assumptions.
- Prefer the narrowest relevant validation command first, then expand scope.

## Documentation Rules
- Keep workshop-facing docs in clear Japanese when editing `docs/ja/`.
- Prefer language that Japanese developers commonly use in practice.
- When adding new workshop pages, keep English and Japanese navigation aligned.

## Working Style
- Summarize expected behavior from the Python source before making C# parity changes.
- Use focused edits that are easy to review and easy to roll back.
- When there is ambiguity, point to the source file or test that defines the current behavior.

