---
description: "Use when implementing or editing the C# migration, Minimal APIs, Program.cs, DTOs, weather.json loading, Swagger, or endpoint parity work."
name: "C# Migration Rules"
applyTo: "src/csharp-app/**/*.{cs,csproj,json}"
---

# C# Migration Rules

- Use ASP.NET Core Minimal APIs.
- Keep `Program.cs` lean and move non-trivial logic into services or helper types.
- Prefer descriptive DTO names and avoid anonymous objects except for trivial root responses.
- Load weather data in a predictable, testable way.
- Keep endpoint additions incremental and easy to validate.
- When changing multiple endpoints, list the impacted routes before editing.
