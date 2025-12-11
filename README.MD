<p align="center">
<img src="img/Banner-MS-AI-Tour-26.png" alt="decorative banner" width="1200"/>
</p>

# [Microsoft AI Tour 2026](https://aitour.microsoft.com)

## WRK541: Real World Code Migration with Github Copilot Agent Mode

[![Microsoft Foundry Discord](https://dcbadge.limes.pink/api/server/Pwpvf3TWaw)](https://aka.ms/MicrosoftFoundryDiscord-AITour26)
[![Microsoft Foundry Developer Forum](https://img.shields.io/badge/GitHub-Microsoft_Foundry_Developer_Forum-blue?style=for-the-badge&logo=github&color=adff2f&logoColor=fff)](https://aka.ms/MicrosoftFoundryForum-AITour26)

If you will be delivering this session, check the [session-delivery-sources](./session-delivery-resources/) folder for slides, scripts, and other resources.

### Session Description

- **Who is this for**: Any technologist that is looking to apply AI pair-programming techniques with GitHub Copilot to perform challenging work like migrating or translating from one programming language to another.
- **What you'll learn**: You'll use advanced GitHub Copilot techniques that are specifically useful when translating projects in different programming languages, as well as the different modes GitHub Copilot has to offer.
- **What you'll build**: An HTTP API migrated from Python to C# (with .NET Minimal APIs), demonstrating how to use GitHub Copilot for real-world code migration scenarios.

### 🧠 Learning Outcomes

In this workshop, you will:

- Learn the differences about each of GitHub Copilot Modes, when to use each one, best practices and tools to help you get the most out of your interactions.
- Understand the Differences Between Python and C# for Web Development
  Learn the key differences in syntax, libraries, and frameworks when transitioning from Python's FastAPI to C#'s ASP.NET Core Minimal APIs.
- Implement JSON Serialization and Deserialization in C#
  Gain hands-on experience using System.Text.Json to handle JSON data, ensuring compatibility with the original Python API.
- Develop and Validate Incremental Endpoints in C#
  Practice creating and testing individual endpoints iteratively, ensuring correctness and alignment with the original Python API.
- Integrate Swagger/OpenAPI Documentation
  Learn to add comprehensive API documentation using Swashbuckle and ASP.NET Core's built-in OpenAPI support.
- Write Unit Tests with MSTest
  Practice creating integration tests using MSTest and WebApplicationFactory to validate API functionality.

## 📣 Prerequisites

Before joining the workshop, there is only one prerequisite: you must have a public GitHub account. All resources, dependencies, and data are part of the repository itself. Make sure you have your GitHub Copilot license, trial, or the free version.

### Run the workshop your way

- **Local machine**: If you already have Git, VS Code with GitHub Copilot, Python 3.12, and the .NET 10 SDK installed, you can clone the repository and follow the exercises locally. A full checklist lives in [PREREQUISITES.md](./PREREQUISITES.md), and the Resources page includes a quick reminder of the required tools.
- **GitHub Codespaces**: Prefer a zero-install setup? Launch a Codespace from the repository page and continue the tutorial in the cloud. The step-by-step guide is in [`docs/en/opening-repository-in-GH-codespaces.md`](./docs/en/opening-repository-in-GH-codespaces.md).

### 💻 Technologies Used

1. GitHub Copilot Chat
1. VS Code
1. Python 3.12
1. C# with .NET 10 (Minimal APIs)
1. MSTest for unit testing
1. Swagger/OpenAPI for API documentation

### 📚 Continued Learning Resources

| Resources          | Links                             | Description        |
|:-------------------|:----------------------------------|:-------------------|
| AI Tour 2026 Resource Center | <https://aka.ms/AITour26-Resource-center> | Links to all repos for AI Tour 26 Sessions |
| Microsoft Foundry Community Discord | [![Microsoft Foundry Discord](https://dcbadge.limes.pink/api/server/Pwpvf3TWaw)](https://aka.ms/MicrosoftFoundryDiscord-AITour26)| Connect with the Microsoft Foundry Community! |
| Learn at AI Tour | <https://aka.ms/LearnAtAITour> | Continue learning on Microsoft Learn |
| Code with GitHub Codespaces | <https://learn.microsoft.com/training/modules/code-with-github-codespaces/> | Try out GitHub Codespaces!
| Using advanced GitHub Copilot features | <https://learn.microsoft.com/training/modules/advanced-github-copilot/> | Some advanced features and tooling

### 🌐 Multi-Language Support

Additional languages coming soon!

## Content Owners

<!-- TODO: Add yourself as a content owner
1. Change the src in the image tag to {your github url}.png
2. Change INSERT NAME HERE to your name
3. Change the github url in the final href to your url. -->

<table>
<tr>
    <td align="center"><a href="https://github.com/elbruno">
        <img src="https://github.com/elbruno.png" width="100px;" alt="Bruno Capuano"
"/><br />
        <sub><b> Bruno Capuano
</b></sub></a><br />
            <a href="https://github.com/elbruno" title="talk">📢</a>
    </td>
    <td align="center"><a href="https://github.com/gcordido">
        <img src="https://github.com/gcordido.png" width="100px;" alt="Gustavo Cordido
"/><br />
        <sub><b>Gustavo Cordido
</b></sub></a><br />
            <a href="https://github.com/gcordido" title="talk">📢</a>
    </td>
</tr></table>

## Responsible AI

Microsoft is committed to helping our customers use our AI products responsibly, sharing our learnings, and building trust-based partnerships through tools like Transparency Notes and Impact Assessments. Many of these resources can be found at [https://aka.ms/RAI](https://aka.ms/RAI).
Microsoft’s approach to responsible AI is grounded in our AI principles of fairness, reliability and safety, privacy and security, inclusiveness, transparency, and accountability.

Large-scale natural language, image, and speech models - like the ones used in this sample - can potentially behave in ways that are unfair, unreliable, or offensive, in turn causing harms. Please consult the [Azure OpenAI service Transparency note](https://learn.microsoft.com/legal/cognitive-services/openai/transparency-note?tabs=text) to be informed about risks and limitations.

The recommended approach to mitigating these risks is to include a safety system in your architecture that can detect and prevent harmful behavior. [Azure AI Content Safety](https://learn.microsoft.com/azure/ai-services/content-safety/overview) provides an independent layer of protection, able to detect harmful user-generated and AI-generated content in applications and services. Azure AI Content Safety includes text and image APIs that allow you to detect material that is harmful. Within Azure AI Foundry portal, the Content Safety service allows you to view, explore and try out sample code for detecting harmful content across different modalities. The following [quickstart documentation](https://learn.microsoft.com/azure/ai-services/content-safety/quickstart-text?tabs=visual-studio%2Clinux&pivots=programming-language-rest) guides you through making requests to the service.

Another aspect to take into account is the overall application performance. With multi-modal and multi-models applications, we consider performance to mean that the system performs as you and your users expect, including not generating harmful outputs. It's important to assess the performance of your overall application using [Performance and Quality and Risk and Safety evaluators](https://learn.microsoft.com/azure/ai-studio/concepts/evaluation-metrics-built-in). You also have the ability to create and evaluate with [custom evaluators](https://learn.microsoft.com/azure/ai-studio/how-to/develop/evaluate-sdk#custom-evaluators).

You can evaluate your AI application in your development environment using the [Azure AI Evaluation SDK](https://microsoft.github.io/promptflow/index.html). Given either a test dataset or a target, your generative AI application generations are quantitatively measured with built-in evaluators or custom evaluators of your choice. To get started with the azure ai evaluation sdk to evaluate your system, you can follow the [quickstart guide](https://learn.microsoft.com/azure/ai-studio/how-to/develop/flow-evaluate-sdk). Once you execute an evaluation run, you can [visualize the results in Azure AI Foundry portal](https://learn.microsoft.com/azure/ai-studio/how-to/evaluate-flow-results).
