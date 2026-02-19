# Glossary

This glossary provides definitions for key terms used throughout the workshop. Use this as a quick reference when you encounter unfamiliar terminology.

## API Terminology

**API (Application Programming Interface)**
: A set of rules and protocols that allows different software applications to communicate with each other.

**Endpoint**
: A specific URL path in an API that performs a particular function (e.g., `/countries` or `/weather`).

**REST (Representational State Transfer)**
: An architectural style for designing networked applications, using standard HTTP methods (GET, POST, PUT, DELETE).

**JSON (JavaScript Object Notation)**
: A lightweight data format that is easy for humans to read and write, and easy for machines to parse and generate.

**HTTP Methods**
: Standard request types including GET (retrieve data), POST (create data), PUT (update data), DELETE (remove data).

**Status Code**
: A three-digit number returned by a server indicating the result of a request (e.g., 200 OK, 404 Not Found, 500 Internal Server Error).

**Swagger/OpenAPI**
: A specification and tooling for documenting REST APIs, providing interactive documentation and testing interfaces.

## .NET & C# Terminology

**ASP.NET Core**
: A cross-platform, high-performance framework for building modern web applications and APIs.

**Minimal APIs**
: A simplified approach in ASP.NET Core for creating APIs with minimal code and configuration.

**.NET SDK (Software Development Kit)**
: A set of tools, libraries, and runtime required to build and run .NET applications.

**Runtime**
: The execution environment that runs .NET applications and manages memory, security, and other system services.

**NuGet**
: The package manager for .NET, used to install and manage third-party libraries and dependencies.

**System.Text.Json**
: A built-in .NET library for serializing and deserializing JSON data.

**Program.cs**
: The entry point file for .NET applications where the application is configured and started.

**Namespace**
: A way to organize code in .NET, preventing naming conflicts by grouping related classes.

## Python Terminology

**FastAPI**
: A modern, fast Python web framework for building APIs with automatic interactive documentation.

**Uvicorn**
: An ASGI (Asynchronous Server Gateway Interface) web server for running Python web applications.

**pip**
: The package installer for Python, used to install libraries and dependencies.

**requirements.txt**
: A file listing Python package dependencies for a project.

**Virtual Environment (venv)**
: An isolated Python environment that keeps dependencies separate from other projects.

## Testing Terminology

**Unit Test**
: A test that validates a single unit of code (function, method, or class) in isolation.

**Integration Test**
: A test that validates how multiple components or systems work together.

**Test Client**
: A tool that simulates HTTP requests to test API endpoints without running a real server.

**Assertion**
: A statement in a test that checks if a condition is true; tests fail if assertions are false.

**Test Coverage**
: A measure of how much of your code is executed by your tests.

**pytest**
: A popular Python testing framework used for writing and running tests.

**MSTest**
: Microsoft's testing framework for .NET applications.

**WebApplicationFactory**
: A .NET testing utility that creates an in-memory test server for integration testing.

## GitHub Copilot Terminology

**GitHub Copilot**
: An AI-powered code completion tool that suggests code and entire functions in real-time.

**Copilot Chat**
: An interactive chat interface where you can ask GitHub Copilot questions and get explanations.

**Context**
: The information GitHub Copilot uses to generate suggestions, including open files, selected code, and chat history.

**Prompt**
: A question or instruction you give to GitHub Copilot to generate code or get information.

**Ask Mode**
: A Copilot mode for getting explanations, asking questions, and learning about code without making changes.

**Agent Mode**
: An autonomous Copilot mode that can plan tasks, make edits, run commands, and iterate until goals are achieved.

**Plan Mode**
: A Copilot mode that helps outline tasks and break down complex work into structured steps.

**#file: Reference**
: A syntax in Copilot chat (e.g., `#file:main.py`) that provides specific file context to improve suggestion accuracy.

**#codebase Tool**
: A Copilot feature that analyzes your entire repository to answer questions about the project structure and code.

## Development Tools

**VS Code (Visual Studio Code)**
: A lightweight but powerful code editor with extensive extension support.

**GitHub Codespaces**
: A cloud-based development environment that runs in your browser with pre-configured tools.

**Git**
: A version control system for tracking changes in code and collaborating with others.

**Terminal/Command Line**
: A text-based interface for running commands and interacting with your operating system.

**Port**
: A numbered communication endpoint where applications listen for network requests (e.g., port 8000 or 5000).

## General Programming Concepts

**Migration**
: The process of moving code from one programming language, framework, or platform to another.

**Scaffolding**
: Generating the basic project structure and boilerplate code to start development quickly.

**Serialization**
: Converting data structures or objects into a format (like JSON) that can be stored or transmitted.

**Deserialization**
: Converting data from a stored or transmitted format (like JSON) back into data structures or objects.

**Type Safety**
: A programming language feature that prevents type errors by checking types at compile-time.

**Compile-time**
: The phase when source code is converted to executable code; errors caught here prevent runtime issues.

**Runtime**
: The phase when a program is actually executing; errors here occur during program execution.

**Dependency**
: An external library or package that your project requires to function properly.

**Boilerplate Code**
: Standard, repetitive code that is necessary but doesn't contain the unique logic of your application.

---

!!! tip "Can't find a term?"
    If you encounter a term not listed here, try asking GitHub Copilot for a definition or check the Resources page for links to official documentation.
