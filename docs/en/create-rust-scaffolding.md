# Create Rust Scaffolding

> *You should use GitHub Copilot in Agent Mode for this step and onwards.*

Now that you have a good understanding of the project and its tests, you can start creating the Rust scaffolding. You will start by creating a special file with instructions. This file is called _Copilot Instructions_ and it should live in the root of the current repository. We've pre-created an empty file for you so all that is needed is to fill it out with new instructions.

For this step, open the `.github/copilot-instructions.md` file and add the
following:

```markdown
Whenever you are providing suggestions for a Rust project always use the
actix-web framework using serde for serialization
```

??? warning 
     Creating a new instance of chat at this point can prove useful. It will clear some of the previous context and allow for GitHub Copilot to start fresh. If you wish to do so, all you need to do is click the ![New Chat Button on GitHub Copilot](./media/copilot-newchat.png) button at the top of Copilot's chat window.

As we will carry out a more complex set of tasks, we will move on from **Edit Mode** and solely work in **Agent Mode**. Once you have switched, ask GitHub Copilot to create the scaffolding necessary for your Rust project. Ask GitHub Copilot to give you a step by step to start the project and the commands to run to get started.



??? Question "Tip"
     Prompt *(Agent Mode)*
     
     `#codespace create the Rust scaffolding to begin migrating the project and provide me with guided steps to run the project afterwards.`


The framework and the serializer should automatically be included without you having to specify it. This file can be used for any other instruction you don't want to repeat.


!!! bug "Why might some dependencies not work as expected? "
     Because LLMs sometimes don't have correct versions and tend to provide probabilistic results, not exact ones like a database would. Ensure that the versions used and installed will work and are correct.