### 4. Strategize with GitHub Copilot

> *Try using GitHub Copilot in Ask Mode for this step.*

Now that you have a good understanding of the project, you can start strategizing with GitHub Copilot. Using **Ask Mode**, ask questions about why the tests might be a good idea when rewriting the project in Rust.

- Ask GitHub Copilot to provide a summary of the tests
- Ask for suggestions on how to properly rewrite this project in Rust

!!! note
    Sometimes, GitHub Copilot may be eager to provide a lot of information including whole files with code. This is probably not what you want when trying to think about your options.
    Ensure you tell Copilot to avoid generating code when brainstorming and strategizing.

??? question "Tip"
    Prompt *(Ask Mode)*

    ```text
    #codebase why are these tests using BASH a good idea if I want to rewrite the
    application from Python to Rust?
    ```


### 5. Identify missing tests

> *For this step you can use either Edit Mode or Agent Mode.*

The tests are not complete and there are some missing cases. Use GitHub Copilot to identify the missing tests. This will help you get full coverage of the application before you start rewriting it in Rust.

For this step, you can use either **Edit Mode** or **Agent Mode**.

- Open the test file and ask GitHub Copilot to identify missing tests
- Implement the missing tests
- Run the tests to ensure they are passing, fix any issues that arise


??? question "Tip"
    Prompt *(Edit Mode)*

    ```text
    Add any missing tests for the endpoints. There are missing cases. Help me get
    coverage
    ```

    Prompt *(Agent Mode)*

    ```text
    Help me run the tests using the BASH file and check that they pass. In case of
    failure, help me address the failures to get the tests passing
    ```

