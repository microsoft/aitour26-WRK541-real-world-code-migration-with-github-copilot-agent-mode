# Adding C# tests

### 11. Finalizing the project with C# tests

Now that you have all the endpoints validated with Python tests, you can optionally add native C# tests to validate the correctness directly in the C# codebase. The Python tests were good enough to validate both Python and C# by using the HTTP API. But if you want, you can use MSTest (or xUnit/NUnit) tests to validate the correctness of the C# project using its own tests.

- Ask Copilot where you can add tests for the C# project. Tests typically go in a separate test project (e.g., `WeatherApi.Tests`).
- Ask how to run the tests for validation
- You can take the approach of adding one test at a time and validate it. This is the same process as before and will help you concentrate on one thing at a time.
- Or you can ask Copilot to scaffold the whole test project and add tests for all endpoints at once.

Try to use Plan Mode for this step. Remember, you must first ask GitHub Copilot to create a plan with your requirements, and once the plan is created and you validated it, you can ask Copilot to execute the plan.

??? question "Tip"
    Prompt *(Plan Mode)*

    ```text
    Now that we have all endpoints in C# I want native C# unit tests using MSTest. 
    Create a test project so that I can verify correctness with C# tests alongside the Python tests.
    If not existing, create a new solution at the root of the c# app [src\csharp-app] and add the main project and the new test project to it.
    Create tests for each endpoint, one at a time, and validate them.
    ```

You should have a fully operating C# application that is well tested by now.
If you are reaching this point, congratulations! You can try achieving these
tasks before time runs out or try them on your own time later.
