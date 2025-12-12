# Workshop Introduction

## Migrating Zava's Temperature API from Python to C #

Zava recently acquired an external company whose apps and services were implemented primarily in Python. Many of those services include temperature, season and location endpoints that are useful for Zava's product line. Since Zava's main backend and operational tooling are built on C#, the engineering leadership started a deliberate migration process to bring the acquired Python services into the C#/.NET ecosystem.

This migration effort is intended to unify the technology stack across Zava's platform, simplify operational maintenance, and enable smoother integration between the acquired services and Zava's existing .NET-based backend. Migrating the Python-based temperature API to C# will provide enhanced type safety via compile-time checking, improved runtime performance, and better alignment with Zava's enterprise tooling and deployment practices on Azure. The API provides historical weather data across multiple countries, cities, and months — data that's essential for Zava's smart fiber products to adapt to different environmental conditions.

This workshop will guide you through a realistic migration scenario using GitHub Copilot: taking an existing Python API (from an acquired codebase), incrementally reimplementing it in C#, and validating that behavior is preserved while improving maintainability and integration with Zava's main backend.

### 🎯 Why This Matters: Real-World Context

!!! info "Understanding Language Migration in Production"

    **Why did Zava choose C# for this migration?**
    
    - Easier integration with Zava's existing C# backend and internal tooling after the acquisition, reducing integration friction and time-to-market
    - First-class Azure ecosystem support (Application Insights, Azure AD integration, IaC tooling) for enterprise deployments
    - Strong enterprise tooling (Visual Studio, JetBrains Rider, .NET analyzers) that improves developer productivity, debugging and refactoring at scale
    
    **Why incremental validation matters in production:**
    
    - **Risk Management**: Testing each endpoint individually minimizes the blast radius of errors
    - **Continuous Verification**: Maintaining Python tests ensures the new implementation matches the original behavior
    - **Confidence Building**: Step-by-step validation provides clear checkpoints and rollback points
    - **Learning from AI**: Validating small changes helps you learn when to trust and when to question AI suggestions

Let's go through some challenging requests for GitHub Copilot and address them
as they happen.

!!! note
    This repo is intended to give an introduction to various **GitHub Copilot** features, such as **Copilot Chat**, **inline chat** and **Agent Mode** within **Visual Studio Code**. Hence the step-by-step guides below contain the general description of what needs to be done, and Copilot can support you in generating the necessary commands.

    Each step (where applicable) also contains a `Cheatsheet / Tip` which can be used to validate the Copilot suggestion(s) against the correct command.

    💡 Play around with different prompts and see how it affects the accuracy of the GitHub Copilot suggestions. For example, when using inline chat, you can use an additional prompt to refine the response without having to rewrite the whole prompt.

## Workshop features

You will be working with a Python project (representing an acquired service) that exposes an HTTP API. This project needs to be migrated and your main task will be to reimplement and integrate it using the C# programming language with .NET Minimal APIs so it fits into Zava's main backend.

### Zava Enterprise Standards — How this migration helps

Zava enforces a set of enterprise standards for services running in production. Below are the key standards and how migrating to C#/.NET helps meet them more effectively than the current Python-based implementation:

- Security and identity: .NET has mature libraries for secure authentication/authorization (Azure AD integration, token validation, strong cryptography libraries) and a robust ecosystem of security scanning and policy enforcement tools.
- Observability and diagnostics: Deep integration with Application Insights, structured logging (ILogger), distributed tracing, and first-class telemetry SDKs make it easier to meet Zava's observability SLAs.
- Reliability and performance: Strong concurrency primitives, the .NET runtime optimizations, and optional ahead-of-time compilation reduce latency and improve throughput for enterprise load patterns.
- Maintainability and governance: Static typing, Roslyn analyzers, standardized NuGet package management, and enforced code quality checks help Zava keep a consistent, auditable codebase across teams.
- CI/CD and deployment automation: Out-of-the-box support for Azure DevOps / GitHub Actions, container tooling, and environment configuration patterns make it straightforward to automate secure blue/green or canary deployments.
- Compliance and auditability: Tooling for static analysis, code scanning, and binary signing, combined with centralized dependency policies, helps satisfy regulatory and internal audit requirements.
- Developer productivity and onboarding: Rich IDE support, deterministic builds, and advanced refactoring tools shorten onboarding time for developers joining Zava's teams.

While Python is an excellent language for many domains, aligning services with Zava's enterprise standards is easier and more consistent within the C#/.NET ecosystem for this organization. The migration strategy in this workshop highlights incremental validation so teams can preserve behavior while gaining these enterprise benefits.

Here are some features:

1. Run the web application and open up the browser
1. Use the /docs endpoint in the running app to see the endpoints
1. All dependencies and libraries are pre-installed for Python
1. Python tests are provided to validate correctness of both Python and C# implementations

## GitHub Copilot Modes

GitHub Copilot offers distinct modes: **Ask**, **Edit**, **Plan** and **Agent**, each designed to enhance your coding workflow in unique ways. These modes cater to different levels of assistance, from answering questions to autonomously managing complex tasks.

### Ask Mode

**Ask Mode** is a Q&A assistant that helps you understand code, solve problems or learn concepts. It allows you to ask questions in natural language, and Copilot responds with explanations, snippets or suggestions. It does not directly modify any code.

!!! tip
    Ask mode works best for quick clarifications, brainstorming solutions and providing sample implementations.

### Edit Mode

**Edit Mode** enables *direct code modifications* based on natural language instructions. You can highlight specific code blocks or files, describe the desired changes, and Copilot will propose edits. These changes are presented as diffs for your review, ensuring you retain control over the final implementation.

!!! tip
    Try Edit mode for targeted updates, such as refactoring or adding error handling. Most of the time, Agent mode is the preferred option over Edit mode for more complex tasks.

### Agent Mode

**Agent Mode** is the most autonomous and powerful of the three. It allows Copilot to analyze your entire project, plan tasks, make edits, run commands, and iterate until the goal is achieved. This mode is ideal for multi-step tasks, such as building features, fixing bugs, or scaffolding new components. While Agent mode automates much of the process, it still surfaces potentially risky actions for your approval, ensuring safety and correctness.

!!! tip
    Agent mode will carry out actions beyond just editing, such as writing code and creating new files. It is best used for tasks that involve more than just prompting for knowledge or editing single lines.

### Plan Mode

**Plan Mode** is a new feature in GitHub Copilot that allows users to outline their coding tasks and objectives more effectively. In this mode, Copilot assists in creating a structured plan for your coding project, helping you break down complex tasks into manageable steps. This can include generating boilerplate code, suggesting project structures, and even identifying potential challenges before you start coding.

!!! tip
    Use Plan Mode to enhance your workflow by setting clear objectives and receiving tailored suggestions for your project.

## Using File References in Prompts

When working with GitHub Copilot throughout this workshop, you'll encounter prompts that use the `#file:filename` syntax. This is an important pattern to understand:

!!! tip "How to Use #file: References - Quick Guide"
    **What it does:** The `#file:filename` syntax provides specific file context to GitHub Copilot, helping it understand exactly which file you're working with.

    **How to use it:**
    
    1. Type `#` in the Copilot chat window
    2. A file picker will appear automatically
    3. Select the file you want to reference (e.g., `main.py` or `Program.cs`)
    4. Then type or paste the rest of your prompt
    
    **Why it matters:** Providing file context helps Copilot generate more accurate and relevant suggestions by understanding your project structure and the specific code you're working on.
    
    **Example:** Instead of asking "add an endpoint", ask "#file:Program.cs add the root endpoint only"

!!! note
    In the prompts where a `#file:filename` is used, it indicates to Copilot the file where the code should be generated.
    You should manually type the `#` and select the file, and then copy and paste the rest of the prompt.
    This is useful when you have multiple files in your project and want to provide specific context to Copilot about which file you're working with.

## Available Models

This workshop is model-agnostic, and as such we do not require learners to select a specific one during their work. However, it is worth noting that GitHub Copilot supports a variety of models (such as GPT models, Claude models, Gemini models, etc.) of varying capabilities. To learn more about GitHub Copilot and its different plans, visit the **Resources** section or visit this link: [GitHub Copilot Plans](https://github.com/features/copilot/plans)
