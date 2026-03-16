# Bonus Challenges

## Challenge 3: Modernize the Migration Workflow with AI Assets

**Difficulty:** 🔥🔥 Advanced

!!! info
    In this challenge, you will take the existing workshop flow and evolve it into a more reusable, production-style AI workflow.

So far, the workshop has guided you through using Ask mode, Plan mode, and Agent mode directly in VS Code by entering prompts as you work. That is a good way to learn the core GitHub Copilot experience.

However, in real projects, it is usually more effective to move repeated instructions, roles, and workflows into project files so they can be reused across tasks and across team members.

In this challenge, you will reshape the workshop approach using these ideas:

- Store shared rules in `copilot-instructions.md`
- Split domain-specific guidance into `*.instructions.md` files
- Define specialized agents in `*.agent.md`
- Turn repeatable workflows into skills with `SKILL.md`
- Combine chat-based work with CLI-driven validation

## Learning Objectives

By completing this challenge, you will learn how to:

- Move from prompt-heavy usage to reusable AI project assets
- Use `copilot-instructions.md` and `*.instructions.md` for persistent guidance
- Design a multi-agent setup for planning, implementation, and validation
- Package repeated workflows as skills
- Use CLI-based commands to tighten the feedback loop during migration work

## Challenge Steps

### Step 1: Capture shared project rules in `copilot-instructions.md`

Start by defining the rules that should apply across the entire workshop.

Examples:

- Treat the Python implementation as the baseline behavior
- Use .NET Minimal APIs for the C# side
- Keep changes incremental and validate one endpoint at a time
- Do not mark work complete without build or test validation
- Keep learner-facing docs clear and easy to understand

!!! tip
    Keep `copilot-instructions.md` focused on rules that truly apply to nearly every task. If it becomes too broad, it can add noise and context overhead.

### Step 2: Add file-specific instructions

Next, add focused instructions under `.github/instructions/`.

For this workshop, a practical split is:

1. `python-analysis.instructions.md`
   - Treat Python routes and tests as the source of truth
   - Extract behavior before proposing C# changes
1. `csharp-migration.instructions.md`
   - Define Minimal API, DTO, service, and Swagger guidance
1. `testing.instructions.md`
   - Define parity validation and test execution expectations

### Step 3: Introduce a multi-agent design

Instead of using one general-purpose agent for everything, split responsibilities.

Recommended setup:

1. `migration-planner.agent.md`
   - Analyze the Python API and determine migration order
1. `migration-implementer.agent.md`
   - Make focused C# changes in small increments
1. `migration-validator.agent.md`
   - Run validation commands and compare behavior
1. `migration-orchestrator.agent.md`
   - Coordinate the other agents and manage phase transitions

!!! important
    Restricting tools by role makes a big difference. For example, the planner should usually be read-only, and the validator should focus on reproduction and explanation rather than editing code.

### Step 4: Turn repeated tasks into skills

Move common workflows into `.github/skills/`.

Good candidates for this workshop include:

- `analyze-python-api`
- `create-csharp-minimal-api`
- `validate-migration-parity`

This reduces repeated prompt-writing and makes your workflow easier to teach and reuse.

### Step 5: Pair AI chat with CLI-based validation

Use AI for reasoning and planning, but keep command execution tight and repeatable.

Examples:

```bash
rg "@app\.|def test_" src/python-app/webapp
cd src/python-app/webapp && pytest test_main.py -k countries -q
cd src/csharp-app && dotnet build
cd src/csharp-app && dotnet run --urls "http://localhost:8000"
curl -i http://localhost:8000/countries
```

If GitHub Copilot CLI is available in your environment, you can also use `gh copilot` to help generate or explain focused commands.

```bash
gh copilot suggest "Command to run only the countries-related tests in src/python-app/webapp/test_main.py"
gh copilot explain "dotnet run --urls http://localhost:8000"
```

!!! note
    Some environments do not have the `gh copilot` subcommand installed by default. Check availability first before relying on it.

## Recommended Workflow

Use the following loop to structure your work.

### Specification Loop

1. Use the planner or a skill to analyze Python behavior
1. Narrow the scope with `rg` or `pytest -k ...`
1. Write down the expected behavior before implementing

### Implementation Loop

1. Ask the implementer agent to change one endpoint or one concern only
1. Run `dotnet build`
1. Verify the affected endpoint with `curl`

### Validation Loop

1. Use the validator to reproduce failures
1. Compare actual behavior with the Python baseline
1. Explain the mismatch clearly
1. Hand off the smallest fix back to the implementer

## Stretch Goals

- Create a real `.github/copilot-instructions.md` for this repository
- Add starter files under `.github/instructions/` and `.github/agents/`
- Implement at least one skill under `.github/skills/`
- Rewrite prompt-heavy workshop steps into agent- or skill-based steps

## Outcome

When you finish this challenge, your repository will contain reusable AI assets instead of depending only on chat history.

- Shared rules
- Domain-specific rules
- Role-based agents
- Reusable skills
- Practical CLI recipes

That turns this workshop from a mode-learning exercise into a more realistic template for team-based AI-assisted development.