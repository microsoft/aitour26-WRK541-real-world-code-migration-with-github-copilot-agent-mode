# WRK541 - Real World Code Migration with GitHub Copilot Agent Mode

![Microsoft AI Tour Banner](./media/aitour-banner.png)

### Perform a challenging migration to a completely different language

- **Who is this for**: Any technologist that is looking to apply AI pair-programming techniques with GitHub Copilot to perform challenging work like migrating or translating from one programming language to another.
- **What you'll learn**: You'll use advanced GitHub Copilot techniques that are specifically useful when translating projects in different programming languages, as well as the different modes GitHub Copilot has to offer.
- **What you'll work on**: An HTTP API used to gather seasonal weather data that uses C# with .NET Minimal APIs with full compatibility from the original HTTP API written in Python.

## Learning Objectives

In this workshop, you will:

- Learn the differences about each of the GitHub Copilot Modes, when to use each one, best practices and tools to help you get the most out of your interactions.
- Understand the differences between Python and C# for web development
- Learn the key differences in syntax, libraries, and frameworks when transitioning from Python's FastAPI to C#'s ASP.NET Core Minimal APIs.
- Implement JSON Serialization and Deserialization in C#.
- Gain hands-on experience using System.Text.Json to handle JSON data, ensuring compatibility with the original Python API.
- Develop and Validate Incremental Endpoints in C#.
- Practice creating and testing individual endpoints iteratively, ensuring correctness and alignment with the original Python API.
- Integrate Swagger/OpenAPI Documentation: Learn to add comprehensive API documentation using Swashbuckle and ASP.NET Core's built-in OpenAPI support.

## 📣 Prerequisites

Before joining the workshop, there is only one prerequisite: you must have your own GitHub account. All resources, dependencies, and data are part of the repository itself. Make sure you have your GitHub Copilot license, trial, or the free version.

### ✅ Before You Begin - Quick Checklist

Make sure you have the following ready before starting the workshop:

- [ ] **GitHub Account**: You have a GitHub account created and can log in
- [ ] **GitHub Copilot Access**: You have GitHub Copilot enabled (paid subscription, trial, or free version)
- [ ] **Environment Choice**: You've decided between:
  - ☁️ **GitHub Codespaces** (recommended - zero setup required)
  - 💻 **Local Development** (requires Python 3.12, .NET 10 SDK, VS Code - see [Resources.md](./resources.md) for full details)
- [ ] **For Local Setup**: All prerequisites are installed and verified (if you chose local development)

!!! tip "Not sure which environment to choose?"
    We recommend GitHub Codespaces for this workshop as it provides a pre-configured environment with all tools ready to use. No installation needed!

### Creating a GitHub Account

If you don't have a GitHub account yet, you can create one for free by following the instructions below.

1. Go to [GitHub's Sign Up Page](https://github.com/join).
2. Enter your email address, create a password, and choose a username. We recommend using a *personal email address* over a work one, to simplify the registration process.
3. Select your Country/Region and agree to the terms of service.
4. Click on the **Create account** button and wait for the verification email to arrive in your inbox.

    ![GitHub Account Sign Up](./media/github_signup.png)

5. Copy the verification code from the email and paste it into the verification field on the GitHub website. Then click on **Continue**.
6. That's it! Now you are ready to go.

Let's get started by clicking on the *Next Button* on the bottom right corner that reads **"Workshop Navigation"**.
