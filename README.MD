# Welcome AI Tour 26 Creators!

Thanks for creating content for AI Tour 26.

One of our opportunities from FY25 was make a more consistent experience for attendees.  Following this template, and keeping users in these repos, will help us achieve this opportunity for this year's AI Tour.

Steps:

## Docs using MKDocs
If you are interested in using mkdocs, this repo is configured for it.
1. update the `mkdocs.yml` file to reference your session. Look particularly for the `site_name`, `site_author`, and `repo_name` tags.
1. Subfolders in the docs folder will show up as tabs in the navigation bar.

If you want to disable mkdocs:
1. Delete the mkdocs.yml file. 
1. Delete the references to it in [docs/README.md](./docs/README.md)
1. Delete the docs/assets folder and its contents.

## Other folders
Note the data, docs, src, lab, session-delivery-resources folders. 
1. Remove folders that you dont need.
1. Please keep and use the folders that you do need.  e.g. put your data in the data folder, and put your docs in the docs folder.

## Update Readme
1. Fill out the content below in this file, below the banner graphic.

## Update Repo Info

1. Note the data, docs, src, lab, session-delivery-resources folders. 

    1. Remove folders that you dont need, but please keep and use the folders that you do need.  e.g. put your data in the data folder, and put your docs in the docs folder.

1. Fill out the content below in this file, below the banner graphic.

1. Update the Repo Info for this repo 
    1. Click the gear icon⚙️ in the upper right.
    1. Set a good description of this repo.
    1. Add the technologies that you're using in this session.  E.g. the same items that are in the Technologies Used section below.

1. Please embed links to Learn with your campaign codes!

## Questions?
Send them to Mike Kinsman, Erik Weis, and cc Anthony Bartolo.

## Last step
Delete this line and everything above it!


<p align="center">
<img src="img/Banner-MS-AI-Tour-26.png" alt="decorative banner" width="1200"/>
</p>

# [Microsoft AI Tour 2026](https://aitour.microsoft.com)

## 🔥BRKXXX: SESSIONNAME

If you will be delivering this session, check the [session-delivery-sources](./session-delivery-resources/) folder for slides, scripts, and other resources.

### Session Description

*Add Session Description*


### 🧠 Learning Outcomes

By the end of this session, learners will be able to:

-  
-
-

### 💻 Technologies Used

1.
1.
1.

### 🔗 Session Resources
| Resources          | Links                             | Description        |
|:-------------------|:----------------------------------|:-------------------|
| Additional Resources for this session | https://learn.microsoft.com | Links specific to this session |

### 📚 Continued Learning Resources
| Resources          | Links                             | Description        |
|:-------------------|:----------------------------------|:-------------------|
| AI Tour 2026 Resource Center | https://aka.ms/AITour26-Resource-center | Links to all repos for AI Tour 26 Sessions |
| Azure AI Foundry Community Discord | [![Microsoft Azure AI Foundry Discord](https://dcbadge.limes.pink/api/server/ByRwuEEgH4)](https://discord.com/invite/ByRwuEEgH4)| Connect with the Azure AI Foundry Community! |
| Learn at AI Tour | https://aka.ms/LearnAtAITour | Continue learning on Microsoft Learn |

### 🌐 Multi-Language Support

*languages will go here when its time to localize*

## Content Owners

<!-- TODO: Add yourself as a content owner
1. Change the src in the image tag to {your github url}.png
2. Change INSERT NAME HERE to your name
3. Change the github url in the final href to your url. -->


<table>
<tr>
    <td align="center"><a href="http://github.com/mikekinsman">
        <img src="https://github.com/mikekinsman.png" width="100px;" alt="INSERT NAME HERE"
"/><br />
        <sub><b> INSERT NAME HERE
</b></sub></a><br />
            <a href="https://github.com/mikekinsman" title="talk">📢</a> 
    </td>
    <td align="center"><a href="http://github.com/mikekinsman">
        <img src="https://github.com/mikekinsman.png" width="100px;" alt="INSERT NAME HERE
"/><br />
        <sub><b>INSERT NAME HERE
</b></sub></a><br />
            <a href="https://github.com/mikekinsman" title="talk">📢</a> 
    </td>
</tr></table>

## 

## Responsible AI 

Microsoft is committed to helping our customers use our AI products responsibly, sharing our learnings, and building trust-based partnerships through tools like Transparency Notes and Impact Assessments. Many of these resources can be found at [https://aka.ms/RAI](https://aka.ms/RAI).
Microsoft’s approach to responsible AI is grounded in our AI principles of fairness, reliability and safety, privacy and security, inclusiveness, transparency, and accountability.

Large-scale natural language, image, and speech models - like the ones used in this sample - can potentially behave in ways that are unfair, unreliable, or offensive, in turn causing harms. Please consult the [Azure OpenAI service Transparency note](https://learn.microsoft.com/legal/cognitive-services/openai/transparency-note?tabs=text) to be informed about risks and limitations.

The recommended approach to mitigating these risks is to include a safety system in your architecture that can detect and prevent harmful behavior. [Azure AI Content Safety](https://learn.microsoft.com/azure/ai-services/content-safety/overview) provides an independent layer of protection, able to detect harmful user-generated and AI-generated content in applications and services. Azure AI Content Safety includes text and image APIs that allow you to detect material that is harmful. Within Azure AI Foundry portal, the Content Safety service allows you to view, explore and try out sample code for detecting harmful content across different modalities. The following [quickstart documentation](https://learn.microsoft.com/azure/ai-services/content-safety/quickstart-text?tabs=visual-studio%2Clinux&pivots=programming-language-rest) guides you through making requests to the service.

Another aspect to take into account is the overall application performance. With multi-modal and multi-models applications, we consider performance to mean that the system performs as you and your users expect, including not generating harmful outputs. It's important to assess the performance of your overall application using [Performance and Quality and Risk and Safety evaluators](https://learn.microsoft.com/azure/ai-studio/concepts/evaluation-metrics-built-in). You also have the ability to create and evaluate with [custom evaluators](https://learn.microsoft.com/azure/ai-studio/how-to/develop/evaluate-sdk#custom-evaluators).

You can evaluate your AI application in your development environment using the [Azure AI Evaluation SDK](https://microsoft.github.io/promptflow/index.html). Given either a test dataset or a target, your generative AI application generations are quantitatively measured with built-in evaluators or custom evaluators of your choice. To get started with the azure ai evaluation sdk to evaluate your system, you can follow the [quickstart guide](https://learn.microsoft.com/azure/ai-studio/how-to/develop/flow-evaluate-sdk). Once you execute an evaluation run, you can [visualize the results in Azure AI Foundry portal ](https://learn.microsoft.com/azure/ai-studio/how-to/evaluate-flow-results).
