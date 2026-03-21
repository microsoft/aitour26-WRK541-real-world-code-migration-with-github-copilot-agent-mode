# Project Checklist

Use this checklist before marking a C# migration step complete.

- The Python source for the target endpoint was reviewed.
- Relevant Python tests were identified.
- Only the necessary C# files were changed.
- `Program.cs` was kept lean where possible.
- DTO or service extraction was used for non-trivial logic.
- `System.Text.Json` remains the default JSON path unless justified otherwise.
- The next validation command is known.

## Typical Validation Commands
- `cd src/csharp-app && dotnet build`
- `cd src/csharp-app/WeatherService.UnitTests && dotnet test`
- `cd src/python-app/webapp && pytest -q`
