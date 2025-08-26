## Migrating Zava's Temperature API from Python to Rust

As part of **Zava**'s business goals, the company is expanding their cutting-edge smart fiber technology to a wider array of retail products. Zava specializes in heat-resistant materials that adapt to various climate conditions, and their current temperature/season/location API serves as a critical backend service for these innovative products.

To support this expansion and ensure enterprise-level reliability, Zava needs to **migrate their existing Python-based temperature API to Rust**. This migration will provide enhanced security through Rust's memory safety features, improved performance with zero-cost abstractions, and better scalability to handle the increased demand from retail market integration. The API currently provides historical weather data across multiple countries, cities, and months - data that's essential for Zava's smart fiber products to perform optimally in different environmental conditions.

This workshop will guide you through the complete migration process using GitHub Copilot, demonstrating how AI-assisted development can streamline the transition from Python to Rust while maintaining full API compatibility and improving overall system robustness.

Let's go through some challenging requests for GitHub Copilot and address them
as they happen.

> [!NOTE]
> This repo is intended to give an introduction to various **GitHub Copilot** features, such as **Copilot Chat** and **inline chat** within **VS Code**. Hence the step-by-step guides below contain the general description of what needs to be done, and Copilot Chat or inline chat can support you in generating the necessary commands.
>
> Each step (where applicable) also contains a `Cheatsheet` which can be used to validate the Copilot suggestion(s) against the correct command.
>
> 💡 Play around with different prompts and see how it affects the accuracy of the GitHub Copilot suggestions. For example, when using inline chat, you can use an additional prompt to refine the response without having to rewrite the whole prompt.

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

> Ask mode works best for quick clarifications, brainstorming solutions and providing sample implementations.

### Edit Mode

**Edit Mode** enables *direct code modifications* based on natural language instructions. You can highlight specific code blocks or files, describe the desired changes, and Copilot will propose edits. These changes are presented as diffs for your review, ensuring you retain control over the final implementation.

> Try Edit mode in targeted updates, such as refactoring or adding error handling.

### Agent Mode

 **Agent Mode** is the most autonomous and powerful of the three. It allows Copilot to analyze your entire project, plan tasks, make edits, run commands, and iterate until the goal is achieved. This mode is ideal for multi-step tasks, such as building features, fixing bugs, or scaffolding new components. While Agent mode automates much of the process, it still surfaces potentially risky actions for your approval, ensuring safety and correctness.


## Start with the Python Project
Familiarize yourself with the project and its structure. The main file is
`main.py`, which contains the main logic of the application. Try to run it and see what the endpoints are.

### 1. Explore the project 

> Try using GitHub Copilot in Ask Mode for this step.

First, open GitHub Copilot by pressing `Ctrl + Alt + I` if you are on Windows, or `Command + Shift + I` if you are on Mac, and ensure you are in **Ask** Mode:

![An image showcasing the three different modes within the GitHub Copilot Chat window](../assets/chat-mode-dropdown-ask.png "GitHub Copilot Modes")

Use the `#codebase` tool to provide context to Copilot and explain what is going on with this project.

- Open GitHub Copilot Chat and prefix your prompt with `#codebase`
- Ask questions like how to run the project

<details>
<summary>Tip</summary>

##### Prompt (Ask Mode)

```text
#codebase provide me a detailed summary of what this Python project is about
```

</details>

### 2. Determine the API endpoints

> Try using GitHub Copilot in Ask Mode for this step.

Launch your project and run the web application. Use GitHub Copilot chat with the `main.py` file open, or type `#main.py` to provide context and ask about the endpoints.

- Try to run the project based on the suggestions of Copilot
- See all the possible endpoints and their requests types


### 3. Explore and run the shell tests

> Try using GitHub Copilot in Agent Mode for this step.

Tests are provided in the `tests` directory. Open the `test_endpoints.sh` file and use it to run tests. It requires the Python application to be running. Run the tests and inspect the output.

- Ask GitHub Copilot if more tests can be added
- If any tests are not currently passing, make sure they are updated

> [!NOTE]
> The application must be running for the tests to pass. If the app is not running you will get http errors.
> You can ask GitHub Copilot in Agent Mode for help to run the application and gain insights on how to start it.

### 4. Strategize with GitHub Copilot

> Try using GitHub Copilot in Ask Mode for this step.

Now that you have a good understanding of the project, you can start strategizing with GitHub Copilot. Using **Ask Mode**, ask questions about why the tests might be a good idea when rewriting the project in Rust.

- Ask GitHub Copilot to provide a summary of the tests
- Ask for suggestions on how to properly rewrite this project in Rust

> [!NOTE]
> Sometimes, GitHub Copilot may be eager to provide a lot of information including whole files with code. This is probably not what you want when trying to think about your options.
> Ensure you tell Copilot to avoid generating code when brainstorming and strategizing.

<details>
<summary>Tip</summary>

##### Prompt (Ask Mode)

```text
#codebase why are these tests using BASH a good idea if I want to rewrite the
application from Python to Rust?
```

</details>


### 5. Identify missing tests

> For this step you can use either Edit Mode or Agent Mode.

The tests are not complete and there are some missing cases. Use GitHub Copilot to identify the missing tests. This will help you get full coverage of the application before you start rewriting it in Rust.

For this step, you can use either **Edit Mode** or **Agent Mode**.

- Open the test file and ask GitHub Copilot to identify missing tests
- Implement the missing tests
- Run the tests to ensure they are passing, fix any issues that arise

<details>
<summary>Tip</summary>

##### Prompt (Edit Mode)

```text
Add any missing tests for the endpoints. There are missing cases. Help me get
coverage
```

##### Prompt (Agent Mode)

```text
Help me run the tests using the BASH file and check that they pass. In case of
failure, help me address the failures to get the tests passing
```

</details>


### 6. Create Rust scaffolding

> You should use GitHub Copilot in Agent Mode for this step and onwards.

Now that you have a good understanding of the project and its tests, you can start creating the Rust scaffolding. You will start by creating a special file with instructions. This file is called _Copilot Instructions_ and it should live in the root of the current repository. We've pre-created an empty file for you so all that is needed is to fill it out with new instructions.

For this step, open the `.github/copilot-instructions.md` file and add the
following:

```markdown
Whenever you are providing suggestions for a Rust project always use the
actix-web framework using serde for serialization
```

As we will carry out a more complex set of tasks, we will move on from **Edit Mode** and solely work in **Agent Mode**. Once you have switched, ask GitHub Copilot to create the scaffolding necessary for your Rust project. Ask GitHub Copilot to give you a step by step to start the project and the commands to run to get started.

The framework and the serializer should automatically be included without you having to specify it. This file can be used for any other instruction you don't want to repeat.


> [!NOTE]
> Why the dependencies might not fully work? Because LLMs sometimes don't have correct versions and tend to provide probabilistic results, not exact ones like a database would. Ensure that the versions used and installed will work and are correct.


### 6. Create a single endpoint
Now that you have the scaffolding, you can start creating a single endpoint. Use Copilot to suggest the first pass for the `main.rs` file that will hold your first endpoint. Ensure that Copilot understands that it shouldn't generate the whole file, but only the main `/` endpoint.

- Open the `main.rs` file and ask Copilot to generate *only* the `/` endpoint

>[!NOTE]
> You might be tempted to ask Copilot to generate the whole file, but you must validate each part as you make progress. It is easier to validate smaller parts than a whole file with multiple endpoints and logic.

<details>
<summary>Tip</summary>

##### Prompt (Agent Mode)

```text
#codebase add the root of the API only. This is the '/' endpoint, do not
generate other endpoints yet, focus only on the single root endpoint for now.
```

</details>

### 7. Validate your first Rust endpoint

Now that you have the first endpoint in Rust, it is time to validate. This process of creating code and validating it is iterative and a solid practice when you need to develop a new project. It is even more crucial now that you are rewriting a project in a new language.

- Make sure the Python project is no longer running
- Ask Copilot help to run the Rust project in the same address and port as the Python project so that tests can run
- Run the tests to ensure they are passing, fix any issues that arise


<details>
<summary>Tip</summary>

##### Prompt (Agent Mode)

```text
Run the Rust project in the same address and port as the Python one. Make sure
the Python API is no longer running. Then, run the BASH tests so that I can
verify the first endpoint in Rust is working. Only focus on the "/" endpoint
for now
```

</details>

### 8. Continue with all other endpoints

Use the same process as above to create all other endpoints. Add a single endpoint at a time, validate it, and run the tests.

For the JSON file, you will need to serialize and use `serde`. If you aren't familiar with this process you will have to rely on Copilot guidance. Ensure that you generate the smallest possible code and validate it immediately.

> [!TIP]
> Validating smaller parts of the code is easier than validating a whole file. It is also easier to debug smaller parts of the code. This is a good practice when using GitHub Copilot and it will help you in the long run.

### 9. Validate correctness

Once you have all endpoints in Rust with passing tests, then you can ask Copilot to do a review of the whole file. Identify potential caveats and issues or performance problems. For example, imagine if every endpoint is serializing the file every time. This is a performance issue and you can ask Copilot to identify it.

<details>
<summary>Tip</summary>

##### Prompt (Agent Mode)

```text
Identify any potential problems with my main.rs file. Specifically I am
interested in understanding redundancy and any code that is doing unnecessary
work. Do not generate any code, just explain.
```

</details>

### 10. Add more endpoints with tests

Finally, you have a 1:1 mapping of the Python project to the Rust project. Now you can start adding more endpoints and tests. For example the `/countries/{country}` endpoint. This endpoint is not present in the Python project, but you can add it to the Rust project.

- With the `main.rs` file open, ask Copilot about other possible endpoints
- Open the `test_endpoints.sh` file and ask Copilot to add more tests for the new endpoints
- Run the tests to ensure they are passing, fix any issues that arise


<details>
<summary>Tip</summary>

##### Prompt (Agent Mode)

```text
The Rust API now has full parity with the Python application, but I want you to
suggest me other potential endpoints that might be useful like
/countries/{country} . Make sure you update the test_endpoints.sh file as well.
```

</details>

### 11. Finalize the project with Rust tests
Now that you have all the endpoints and tests passing, you can now use Rust tests to validate the correctness. The shell tests were good enough to validate both Python and Rust by using the HTTP API. But now you can use Rust tests to validate the correctness of the Rust project using its own tests.

- Ask Copilot where you can add tests for the Rust project. Tests can go in the same `main.rs` file or in a separate file.
- Ask how to run the tests for validation
- Only add one test a time and validate it. This is the same process as before and will help you concentrate in one thing at a time.

<details>
<summary>Tip</summary>

##### Prompt (Agent Mode)

```text
Now that we have all endpoints in Rust I want native Rust unit tests. Add them
to main.rs so that I can verify correctness without having to use the BASH file
```

</details>


### BONUS Challenge!

You should have a fully operating Rust application that is well tested by now.
If you are reaching this point, congratulations! You can try achieving these
tasks before time runs out or try them on your own time later.


**Bonus Challenge 1**

Containerize this project so that users can run it in other environments
without having to install and compile dependencies.

You can start with Agent mode to create the Dockerfile, then switch over to
Edit mode when making updates to the Dockerfile. Finally, switch over to Agent
mode to get guidance verifying the container.

1. Ask Copilot to help you generate a Dockerfile to containerize the Rust
   project
1. Review the Dockerfile created, optionally switch to Edit mode to make
   specific changes to the file
1. Use Agent mode to verify the container builds and can run

Make adjustments as needed to ensure the container works.


**Bonus Challenge 2**

> [!NOTE]
> You may have a `Makefile` already created by Copilot as part of this
> workshop. If that is the case, just make the updates necessary, otherwise
> create a new one.

Create a useful `Makefile` to make it easier to interact with the Rust project.
Use GitHub Copilot in Agent mode for this challenge. Use Agent mode to achieve
the following:

1. Create a Makefile with build, build-container, test, and run targets
1. Make the `Makefile` produce a useful help menu when no targets are passed in
1. Explore additional targets like release-build and similar that GitHub
   Copilot might suggest in Ask mode

**Take Home**

If you have achieved all previous steps including the containerization, try
deploying your application on Azure. For this you will need an Azure account
and [the GitHub Copilot for Azure
extension](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azure-github-copilot)
which will help you ask questions and get guidance for deployment.

1. Use `@azure` after signing into your Azure account to ask how to deploy the
   containerized Rust application
1. Use one of the suggested services for deployment, for example, Azure
   Container Apps, to deploy the container
1. Verify your container is deployed and working

By the end, ensure you cleanup and remove any and all resources to prevent
unneeded cloud charges to your account.
