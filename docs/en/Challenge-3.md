# Bonus Challenges

## Challenge 3: Modernize the Migration Workflow with AI Assets

**Difficulty:** 🔥🔥 Advanced

!!! info
    In this challenge, you will take the existing workshop flow and evolve it into a more reusable, production-style AI workflow.

So far, the workshop has guided you through using Ask mode, Plan mode, and Agent mode directly in VS Code by entering prompts as you work. That is a good way to learn the core GitHub Copilot experience.

However, in real projects, it is usually more effective to move repeated instructions, roles, and workflows into project files so they can be reused across tasks and across team members.

In this challenge, you will use the instructions, agents, and skills that were added to this repository and apply them in a more modern workflow:

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

### Step 1: Review the shared project rules

Start by reviewing how the shared rules are captured in `.github/copilot-instructions.md`.

Examples:

- Treat the Python implementation as the baseline behavior
- Use .NET Minimal APIs for the C# side
- Keep changes incremental and validate one endpoint at a time
- Do not mark work complete without build or test validation
- Keep learner-facing docs clear and easy to understand

!!! tip
   Read `copilot-instructions.md` before starting. It defines the baseline expectations that all planner / implementer / validator tasks should follow.

### Step 2: Review the file-specific instructions

Next, review the focused instructions under `.github/instructions/`.

For this workshop, a practical split is:

1. `python-analysis.instructions.md`
   - Treat Python routes and tests as the source of truth
   - Extract behavior before proposing C# changes
1. `csharp-migration.instructions.md`
   - Define Minimal API, DTO, service, and Swagger guidance
1. `testing.instructions.md`
   - Define parity validation and test execution expectations

### Step 3: Work with a multi-agent design

Instead of using one general-purpose agent for everything, use role-specific agents.

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

### Step 4: Use skills for repeatable tasks

Use the skills under `.github/skills/` for the workflows you repeat most often.

Good candidates for this workshop include:

- `analyze-python-api`
- `create-csharp-minimal-api`
- `validate-migration-parity`

This reduces repeated prompt-writing and makes your workflow easier to teach and reuse.

## Files Used in This Challenge

This challenge assumes you will use the following files directly.

### Shared rules

- `.github/copilot-instructions.md`

### Instructions

- `.github/instructions/python-analysis.instructions.md`
- `.github/instructions/csharp-migration.instructions.md`
- `.github/instructions/testing.instructions.md`

### Agents

- `.github/agents/migration-planner.agent.md`
- `.github/agents/migration-implementer.agent.md`
- `.github/agents/migration-validator.agent.md`
- `.github/agents/migration-orchestrator.agent.md`

### Skills

- `.github/skills/analyze-python-api/SKILL.md`
- `.github/skills/create-csharp-minimal-api/SKILL.md`
- `.github/skills/validate-migration-parity/SKILL.md`

## How to Execute the Work Using Agents and Skills

### Pattern 1: Start with the orchestrator

The most production-oriented way to run this challenge is to start with `migration-orchestrator`.

1. Open `migration-orchestrator`
1. Ask it to analyze the next unimplemented endpoint and decide the implementation and validation order
1. Let it delegate planning work to `migration-planner`
1. Let it delegate implementation to `migration-implementer`
1. Let it delegate validation to `migration-validator`

This pattern is useful because the learner does not need to decide manually which specialist should act next.

### Pattern 2: Switch agents manually

If you want learners to understand role boundaries more explicitly, use the agents manually in this order:

1. `migration-planner`
1. `migration-implementer`
1. `migration-validator`

This makes it easier to see the difference between planning, implementation, and validation work.

## Concrete Examples with Skills

### 1. Analyze the Python API

Use `analyze-python-api` first to clarify expected behavior.

Example:

```text
/analyze-python-api Review src/python-app/webapp/main.py and test_main.py,
and summarize the behavior of /countries and /weather.
```

Expected output:

- Route inventory
- Input parameters
- Success responses
- Error behavior
- What is explicitly guaranteed by tests

### 2. Implement the next C# endpoint

Then use `create-csharp-minimal-api` or `migration-implementer` to make the next small change.

Example:

```text
/create-csharp-minimal-api Implement only the /countries endpoint,
keeping the response aligned with the Python behavior.
```

Or:

```text
Use migration-implementer to add only /countries,
then report the changed files and the next validation command.
```

### 3. Validate parity

After implementation, use `validate-migration-parity` or `migration-validator`.

Example:

```text
/validate-migration-parity Show the smallest validation steps needed to confirm
that /countries matches the Python implementation.
```

Or:

```text
Use migration-validator to run the relevant pytest checks and C# build checks,
then explain any mismatch.
```

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

1. Use `analyze-python-api` or `migration-planner` to analyze Python behavior
1. Narrow the scope with `rg` or `pytest -k ...`
1. Write down the expected behavior before implementing

### Implementation Loop

1. Use `create-csharp-minimal-api` or `migration-implementer` to change one endpoint or one concern only
1. Run `dotnet build`
1. Verify the affected endpoint with `curl`

### Validation Loop

1. Use `validate-migration-parity` or `migration-validator` to reproduce failures
1. Compare actual behavior with the Python baseline
1. Explain the mismatch clearly
1. Hand off the smallest fix back to the implementer

## Stretch Goals

- Complete one endpoint from planning through validation using `migration-orchestrator`
- Rewrite one existing prompt-heavy workshop step into an agent / skill based version
- Break validation into even smaller loops using `validate-migration-parity`
- Add one more reusable skill for your team

## Outcome

When you finish this challenge, your repository will contain reusable AI assets instead of depending only on chat history.

- Shared rules
- Domain-specific rules
- Role-based agents
- Reusable skills
- Practical CLI recipes

That turns this workshop from a mode-learning exercise into a more realistic template for team-based AI-assisted development.