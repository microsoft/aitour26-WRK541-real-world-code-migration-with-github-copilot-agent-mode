

### 9. Validate correctness

Once you have all endpoints in Rust with passing tests, then you can ask Copilot to do a review of the whole file. Identify potential caveats and issues or performance problems. For example, imagine if every endpoint is serializing the file every time. This is a performance issue and you can ask Copilot to identify it.

??? question "Tip"
    Prompt *(Agent Mode)*

    ```text
    Identify any potential problems with my main.rs file. Specifically I am
    interested in understanding redundancy and any code that is doing unnecessary
    work. Do not generate any code, just explain.
    ```


### 10. Add more endpoints with tests

Finally, you have a 1:1 mapping of the Python project to the Rust project. Now you can start adding more endpoints and tests. For example the `/countries/{country}` endpoint. This endpoint is not present in the Python project, but you can add it to the Rust project.

- With the `main.rs` file open, ask Copilot about other possible endpoints
- Open the `test_endpoints.sh` file and ask Copilot to add more tests for the new endpoints
- Run the tests to ensure they are passing, fix any issues that arise

??? question "Tip"
    Prompt *(Agent Mode)*

    ```text
    The Rust API now has full parity with the Python application, but I want you to
    suggest me other potential endpoints that might be useful like
    /countries/{country} . Make sure you update the test_endpoints.sh file as well.
    ```