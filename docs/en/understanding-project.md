# Understanding the Project

Before we start migrating code, it's crucial to understand what we're working with.

## Start with the Python Project

Familiarize yourself with the project and its structure. The main file is `main.py`, and is located within the `src` directory, under the `python-app\webapp` folder. This file contains the main logic of the application.

### 1. Explore the project

> Try using GitHub Copilot in Ask Mode for this step.

First, open GitHub Copilot by pressing `Ctrl + Alt + I` if you are on Windows, or `Command + Shift + I` if you are on Mac, and ensure you are in **Ask** Mode:

![An image showcasing the three different modes within the GitHub Copilot Chat window](./media/chat-mode-dropdown-ask.png)

!!! Note
    GitHub Copilot is based on LLMs and therefore it has a non-deterministic behavior; you might get different responses to the same input prompt. The suggested prompts in this repo have been tested with model **GPT-5-mini**, so you might want to choose that model from the dropdown menu. However, you are also welcome to explore different models.

![Model choice dropdown](./media/model-picker.png)

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

Next, we will launch the project and run the web application. Let's use GitHub Copilot chat with the `main.py` file open, or type `#main.py` to provide context and ask about the endpoints.

!!! tip "When Copilot output include a terminal command you can click on the button in the right upper corner to paste it directly in the terminal. ![Paste to terminal](./media/paste_to_terminal.png)"

- Ask how to run the web application

??? question "Tip"

    Prompt (Ask Mode)

    ```text
    #main.py how do I run the python webapp? 
    ```

- Try to run the project based on the suggestions of Copilot  

!!! tip
    You'll need to have a terminal opened and you'll need **uvicorn** to execute the FastAPI application.

!!! warning
    If you are getting the following error message "Error loading ASGI app. Could not import module (...)", make sure the path suggested by Copilot in its output is the correct file path of the app logic (main.py).
    Ensure you are in the correct directory: `src\python-app\webapp` to run the app.

- See all the possible endpoints and their requests types, by navigating to the swagger UI page, whose url is printed in the app startup output.

!!! tip "Have a look to [weather.json](https://github.com/microsoft/aitour26-WRK541-real-world-code-migration-with-github-copilot-agent-mode/blob/main/src/python-app/webapp/weather.json) file to check the allowed parameters to test the endpoints."

### 3. Explore and run the Python tests

> *Try using GitHub Copilot in Agent Mode for this step.*

Tests are provided in the `src/python-app/webapp/test_main.py` file. This Python test file uses FastAPI's TestClient to validate the API endpoints. Run the tests and inspect the output.

With the app already running in a terminal, open a new terminal and run the Python tests using pytest:

```bash
cd src/python-app/webapp
pytest test_main.py -v
```

- If any tests are not currently passing, leverage GitHub Copilot to help you fix them and then re-run the tests.

!!! note
    These tests use HTTP requests and require the application to be running before executing the tests. The tests will automatically skip if the app is not running at the configured BASE_URL (default: <http://localhost:8000>).

    These same tests will be used to validate the C# web app by setting the BASE_URL environment variable to match the C# app's port (e.g., `$env:BASE_URL="http://localhost:5000"` on Windows or `export BASE_URL="http://localhost:5000"` on Linux/Mac).
