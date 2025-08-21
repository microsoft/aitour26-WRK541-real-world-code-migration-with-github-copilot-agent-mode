Now that you have the scaffolding, you can start creating a single endpoint. Use Copilot to suggest the first pass for the `main.rs` file that will hold your first endpoint. Ensure that Copilot understands that it shouldn't generate the whole file, but only the main `/` endpoint.

### 6. Create a single endpoint

- Open the `main.rs` file and ask Copilot to generate *only* the `/` endpoint

!!! note
    You might be tempted to ask Copilot to generate the whole file, but you must validate each part as you make progress. It is easier to validate smaller parts than a whole file with multiple endpoints and logic.


??? question "Tip"
    Prompt *(Agent Mode)*

    ```text
    #codebase add the root of the API only. This is the '/' endpoint, do not
    generate other endpoints yet, focus only on the single root endpoint for now.
    ```


### 7. Validate your first Rust endpoint

Now that you have the first endpoint in Rust, it is time to validate. This process of creating code and validating it is iterative and a solid practice when you need to develop a new project. It is even more crucial now that you are rewriting a project in a new language.

- Make sure the Python project is no longer running
- Ask Copilot help to run the Rust project in the same address and port as the Python project so that tests can run
- Run the tests to ensure they are passing, fix any issues that arise

??? question "Tip"
    Prompt *(Agent Mode)*

    ```text
    Run the Rust project in the same address and port as the Python one. Make sure
    the Python API is no longer running. Then, run the BASH tests so that I can
    verify the first endpoint in Rust is working. Only focus on the "/" endpoint
    for now
    ```

### 8. Continue with all other endpoints

Use the same process as above to create all other endpoints. Add a single endpoint at a time, validate it, and run the tests.

For the JSON file, you will need to serialize and use `serde`. If you aren't familiar with this process you will have to rely on Copilot guidance. Ensure that you generate the smallest possible code and validate it immediately.

!!! success "Validating smaller parts of the code is easier than validating a whole file. It is also easier to debug smaller parts of the code. This is a good practice when using GitHub Copilot and it will help you in the long run."
