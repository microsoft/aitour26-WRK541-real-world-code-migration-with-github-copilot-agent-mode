### 11. Finalizing the project with Rust tests
Now that you have all the endpoints and tests passing, you can now use Rust tests to validate the correctness. The shell tests were good enough to validate both Python and Rust by using the HTTP API. But now you can use Rust tests to validate the correctness of the Rust project using its own tests.

- Ask Copilot where you can add tests for the Rust project. Tests can go in the same `main.rs` file or in a separate file.
- Ask how to run the tests for validation
- Only add one test a time and validate it. This is the same process as before and will help you concentrate in one thing at a time.

??? question "Tip"
    Prompt *(Agent Mode)*

    ```text
    Now that we have all endpoints in Rust I want native Rust unit tests. Add them
    to main.rs so that I can verify correctness without having to use the BASH file
    ```

You should have a fully operating Rust application that is well tested by now.
If you are reaching this point, congratulations! You can try achieving these
tasks before time runs out or try them on your own time later.