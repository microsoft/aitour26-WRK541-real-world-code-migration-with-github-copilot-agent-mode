# Workshop Introduction

## Migrating Zava's Temperature API from Python to Rust

As part of **Zava**'s business goals, the company is expanding their cutting-edge smart fiber technology to a wider array of retail products. Zava specializes in heat-resistant materials that adapt to various climate conditions, and their current temperature/season/location API serves as a critical backend service for these innovative products.

To support this expansion and ensure enterprise-level reliability, Zava needs to **migrate their existing Python-based temperature API to Rust**. This migration will provide enhanced security through Rust's memory safety features, improved performance with zero-cost abstractions, and better scalability to handle the increased demand from retail market integration. The API currently provides historical weather data across multiple countries, cities, and months - data that's essential for Zava's smart fiber products to perform optimally in different environmental conditions.

This workshop will guide you through the complete migration process using GitHub Copilot, demonstrating how AI-assisted development can streamline the transition from Python to Rust while maintaining full API compatibility and improving overall system robustness.

Let's go through some challenging requests for GitHub Copilot and address them
as they happen.

!!! note
    This repo is intended to give an introduction to various **GitHub Copilot** features, such as **Copilot Chat** and **inline chat** within **VS Code**. Hence the step-by-step guides below contain the general description of what needs to be done, and Copilot Chat or inline chat can support you in generating the necessary commands.

    Each step (where applicable) also contains a `Cheatsheet` which can be used to validate the Copilot suggestion(s) against the correct command.

    💡 Play around with different prompts and see how it affects the accuracy of the GitHub Copilot suggestions. For example, when using inline chat, you can use an additional prompt to refine the response without having to rewrite the whole prompt.

## Workshop features

You will be working with a Python project that has an HTTP
API. This project needs to be migrated and your main task will be to migrate
it over using the Rust programming language.
Here are some features:

1. Run the web application and open up the browser
1. Use the /docs endpoint in the running app to see the endpoints
1. All dependencies and libraries are pre-installed for Python
1. An initial test file in BASH is provided to validate correctness

## GitHub Copilot Modes

GitHub Copilot offers three distinct modes: **Ask, Edit** and **Agent**, each designed to enhance your coding workflow in unique ways. These modes cater to different levels of assistance, from answering questions to autonomously managing complex tasks.

### Ask Mode

**Ask Mode** is a Q&A assistant that helps you understand code, solve problems or learn concepts. It allows you to ask questions in natural language, and Copilot responds with explanations, snippets or suggestions. It does not directly modify any code. 

!!! tip "Ask mode works best for quick clarifications, brainstorming solutions and providing sample implementations."

### Edit Mode

**Edit Mode** enables *direct code modifications* based on natural language instructions. You can highlight specific code blocks or files, describe the desired changes, and Copilot will propose edits. These changes are presented as diffs for your review, ensuring you retain control over the final implementation.

!!! tip "Try Edit mode in targeted updates, such as refactoring or adding error handling."

### Agent Mode

 **Agent Mode** is the most autonomous and powerful of the three. It allows Copilot to analyze your entire project, plan tasks, make edits, run commands, and iterate until the goal is achieved. This mode is ideal for multi-step tasks, such as building features, fixing bugs, or scaffolding new components. While Agent mode automates much of the process, it still surfaces potentially risky actions for your approval, ensuring safety and correctness.

!!! tip "Agent mode will carry out actions beyond just editing, such as writing code and creating new files. It is best used in tasks that imply more than just prompting for knowledge or editing single lines."

## Available Models

This workshop is model-agnostic, and as such we do not require learners to select a specific one during their work. However, it is worth noting that GitHub Copilot supports a variety of models (such as GPT-5, Claude Sonnet 4, Gemini, etc.) of varying capabilities. To learn more about GitHub Copilot and its different plans, visit the **Resources** section or visit this link: [GitHub Copilot Plans](https://github.com/features/copilot/plans)