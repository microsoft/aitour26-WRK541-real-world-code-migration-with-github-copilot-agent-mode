# Validate correctness and add more endpoints

### 9. Validate correctness

Once you have all endpoints in C# with passing Python tests, then you can ask Copilot to do a review of the whole file. Identify potential caveats and issues or performance problems. For example, imagine if every endpoint is deserializing the file every time. This is a performance issue and you can ask Copilot to identify it.

??? question "Tip"
    Prompt *(Agent Mode)*

    ```text
    Identify any potential problems with my Program.cs file. 
    Specifically I am interested in understanding redundancy and any code that is doing unnecessary work. 
    Do not generate any code, just explain.
    ```

### 10. Add more endpoints with tests

Finally, you have a 1:1 mapping of the Python project to the C# project. Now you can start adding more endpoints and tests. For example the `/countries/{country}` endpoint. This endpoint is not present in the Python project, but you can add it to the C# project.

- With the `Program.cs` file open, ask Copilot about other possible endpoints
- Open the `test_main.py` file in the Python app and ask Copilot to add more tests for the new endpoints
- Run the tests to ensure they are passing, fix any issues that arise

??? question "Tip"
    Prompt *(Ask Mode)*

    ```text
    The C# API now has full parity with the Python application, but I want you to
    suggest me other potential endpoints that might be useful.
    ```

??? question "Tip"
    Prompt *(Agent Mode)*

    ```text
    #file:Program.cs implement /countries/{country} endpoint and add a test to assess it.
    ```
