# Create C# Scaffolding

> *You should use GitHub Copilot in Agent Mode for this step and onwards.*

Now that you have a good understanding of the project and its tests, you can start creating the C# scaffolding. You will start by customising the repository-wide *Copilot Instructions* file, which lives at `.github/copilot-instructions.md` in the root of the repository. This file has been pre-populated with Python-focused guidance, and you will replace its contents with C#-focused instructions for the migration ahead.

!!! note "`.github/copilot-instructions.md` vs `.github/instructions/`"
    `.github/copilot-instructions.md` is the single repository-wide instructions file that Copilot loads for every chat in this repo. The `.github/instructions/` folder is a different mechanism — it holds multiple glob-scoped files (with `applyTo` frontmatter) that only activate when you edit matching paths. Those files are already populated and should not be edited for this step.

For this step, open `.github/copilot-instructions.md` and **replace its entire contents** with the following:

```markdown
# C# .NET 10 WebApi Migration Instructions

## Overview

This guide helps developers migrate the Python Weather API to C# .NET 10 using ASP.NET Core Minimal APIs.

## Requirements

- **Framework**: ASP.NET Core Minimal APIs (.NET 10)
- **JSON Serialization**: System.Text.Json (built-in)
- **API Documentation**: Swashbuckle (OpenAPI/Swagger support)

## Development Workflow

- **Build**: `dotnet build`
- **Run**: `dotnet run`
- **Test**: `dotnet test` (tests in `WeatherApi.Tests` directory)
- **API Docs**: Available at `/swagger` endpoint when running

## C# API Guidelines

- Use **Minimal APIs** for endpoint definitions in `Program.cs`
- Use **System.Text.Json** for all serialization
- Add Swashbuckle attributes to endpoints for automatic Swagger documentation
- Follow PascalCase for class names, camelCase for methods
- Example: See `src/csharp-app/WeatherApi/Program.cs`

## Key Files

- `src/csharp-app/WeatherApi/Program.cs` - API configuration and endpoints
- `src/csharp-app/WeatherApi.Tests/` - Unit tests
- `src/csharp-app/WeatherApi/Models.cs` - Data models
- `src/csharp-app/WeatherApi/weather.json` - Sample data
```

??? warning
     Creating a new instance of chat at this point can prove useful. It will clear some of the previous context and allow for GitHub Copilot to start fresh. If you wish to do so, all you need to do is click the ![New Chat Button on GitHub Copilot](./media/copilot-newchat.png) button at the top of Copilot's chat window.

As we will carry out a more complex set of tasks, we will work in **Agent Mode**. Once you have switched, ask GitHub Copilot to create the scaffolding necessary for your C# project. Ask GitHub Copilot to give you a step by step to start the project and the commands to run to get started.

??? question "Tip"
     Prompt *(Agent Mode)*

    ```text
    Create a new folder named `csharp-app` in the `src` directory.
    Create the C# scaffolding in csharp-app folder, where we are going to migrate the python project. 
    Use .NET Minimal APIs. 
    Don't perform any code migration for now. 
    Provide me with guided steps to run the project afterwards. 
    Create the minimal code necessary to have a running C# .NET 10 Web API project.
    ```

Once GitHub Copilot has created the scaffolding, have a look at the files created in the `csharp-app` folder. You should see a `.csproj` file and a `Program.cs` file.

(Optional) Ask GitHub Copilot to clarify any doubts you might have about the files created and their purpose.
