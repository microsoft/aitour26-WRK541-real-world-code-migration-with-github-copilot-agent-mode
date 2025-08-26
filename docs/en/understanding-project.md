# Understanding the Project

Before we start migrating code, it's crucial to understand what we're working with.

## Start with the Python Project
Familiarize yourself with the project and its structure. The main file is `main.py`, and is located within the `src` directory, under the `python-app` folder. This file contains the main logic of the application. Try to run it and see what the endpoints are.

### 1. Explore the project 

> Try using GitHub Copilot in Ask Mode for this step.

First, open GitHub Copilot by pressing `Ctrl + Alt + I` if you are on Windows, or `Command + Shift + I` if you are on Mac, and ensure you are in **Ask** Mode:

![An image showcasing the three different modes within the GitHub Copilot Chat window](./media/chat-mode-dropdown-ask.png "GitHub Copilot Modes")

Use the `#codebase` tool to provide context to Copilot and explain what is going on with this project.

- Open GitHub Copilot Chat and prefix your prompt with `#codebase`
- Ask questions like how to run the project

??? question "Tip"

    Prompt (Ask Mode)

    ```text
    #codebase provide me a detailed summary of what this Python project is about
    ```


### 2. Determine the API endpoints

> *Try using GitHub Copilot in Ask Mode for this step.*

Launch your project and run the web application. Use GitHub Copilot chat with the `main.py` file open, or type `#main.py` to provide context and ask about the endpoints.

- Try to run the project based on the suggestions of Copilot
- See all the possible endpoints and their requests types


### 3. Explore and run the shell tests

> *Try using GitHub Copilot in Agent Mode for this step.*

Tests are provided in the `tests` directory. Open the `test_endpoints.sh` file and use it to run tests. It requires the Python application to be running. Run the tests and inspect the output.

- Ask GitHub Copilot if more tests can be added
- If any tests are not currently passing, make sure they are updated

!!! warning
    The application must be running for the tests to pass. If the app is not running you will get http errors.
    You can ask GitHub Copilot in Agent Mode for help to run the application and gain insights on how to start it.