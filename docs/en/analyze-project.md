### 4. Strategize with GitHub Copilot

> *Try using GitHub Copilot in Ask Mode for this step.*

Now that you have a good understanding of the project, you can start strategizing with GitHub Copilot. Using **Ask Mode**, ask questions about why the Python tests might be useful when rewriting the project in C#.

- Ask GitHub Copilot to provide a summary of the tests

??? question "Tip"
    Prompt *(Ask Mode)*

    ```text
    #file:test_main.py provide a summary of the tests for the python application in this repository
    ```

- Ask GitHub Copilot to explain why the tests are a good way to validate the C# migration

??? question "Tip"
    Prompt *(Ask Mode)*

    ```text
    #file:test_main.py why are the Python tests in test_main.py a good way to validate the C# rewrite?
    ```

- Ask for suggestions on how to properly rewrite this project in C#

!!! note
    Sometimes, GitHub Copilot may be eager to provide a lot of information including whole files with code. This is probably not what you want when trying to think about your options.
    Ensure you tell Copilot to avoid generating code when brainstorming and strategizing.

??? question "Tip"
    Prompt *(Ask Mode)*

    ```text
    Just provide suggestions on how to properly rewrite this project in C#.
    Keep this high level.
    Do not change any code. 
    ```

### 5. Identify missing tests

The Python tests may not be complete and there could be some missing cases. Use GitHub Copilot to identify the missing tests. This will help you get full coverage of the application before you start rewriting it in C#.

For this step, you must use **Agent Mode**.

- Open the test file (`test_main.py`) and ask GitHub Copilot to identify missing tests
- Implement the missing tests
- Run the tests to ensure they are passing, fix any issues that arise

??? question "Tip"
    Prompt *(Agent Mode)*

    ```text
    Analyze the python application.
    Help me run the Python tests in src/python-app/webapp/test_main.py and check that they pass. 
    In case of failure, help me address the failures to get the tests passing
    ```
