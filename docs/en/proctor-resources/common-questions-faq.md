# Common Attendee Questions - FAQ for Proctors

This document provides proctors with ready answers to frequently asked questions during the workshop. Use this as a quick reference to provide consistent, helpful responses to attendees.

## GitHub Copilot Questions

### Q: "Why isn't Copilot suggesting anything?"

**Quick Check:**
- Is Copilot enabled in VS Code? (Look for Copilot icon in status bar)
- Is the file saved? Copilot works better with saved files
- Is there enough context? Open relevant files or use `#file:` references

**Troubleshooting Steps:**
1. Check if Copilot is active (icon should not show an error)
2. Verify model selection - try switching to a different model
3. Reload VS Code window (`Ctrl+Shift+P` → "Reload Window")
4. Check internet connectivity
5. Sign out and back into GitHub account

**Answer to Give:**
"Let's check a few things. First, can you see the Copilot icon in your status bar? Let's make sure your file is saved and try providing more context by using #file: references in your prompt."

---

### Q: "Can I use a different model? Which one is best?"

**Answer:**
"Yes! GitHub Copilot supports multiple models. For this workshop, we've tested with GPT-4o-mini, but you're welcome to experiment with other models like Claude or Gemini. Different models may give different suggestions - there's no single 'best' model, but GPT-4o tends to be more accurate for complex tasks while GPT-4o-mini is faster."

**How to Switch:**
- Click the model name in Copilot Chat
- Select from available models
- Try a different model if suggestions aren't helpful

---

### Q: "Is Agent Mode 'cheating'? Shouldn't I write the code myself?"

**Answer:**
"Great question! Agent Mode isn't cheating - it's a tool that mimics how you'd work with a senior developer. The learning happens in:

- Understanding what to ask for
- Validating the generated code
- Debugging when things don't work
- Deciding when to trust vs verify

Think of it as pair programming with AI. You're still making all the important decisions, and you're learning patterns you can apply later."

---

### Q: "Copilot's suggestion doesn't match the instructions. What should I do?"

**Answer:**
"This is a great learning moment! Remember:

1. **Verify first**: Compare Copilot's output with the expected behavior
2. **Refine your prompt**: Be more specific about what you want
3. **Iterate**: Give Copilot feedback and ask it to adjust
4. **Use validation**: Run the tests to verify correctness

AI suggestions aren't always perfect. Learning when to accept, modify, or reject suggestions is a valuable skill."

---

## Testing Questions

### Q: "My tests are failing but I did exactly what Copilot said. What now?"

**Troubleshooting Guide:**

1. **Check if the app is running:**
   - Python tests require the app to be running first
   - Verify: `curl http://localhost:8000` should return a response

2. **Check the port:**
   - Python app runs on port 8000
   - C# app should also run on port 8000 for test compatibility
   - Use `--urls "http://localhost:8000"` when running C# app

3. **Check the BASE_URL environment variable:**
   - Windows: `$env:BASE_URL="http://localhost:8000"`
   - Linux/Mac: `export BASE_URL="http://localhost:8000"`

4. **Review test output:**
   - Look at the specific assertion that failed
   - Compare expected vs actual values
   - Ask Copilot about the specific error message

**Answer to Give:**
"Let's debug this together. First, is your app running? Let me see the test output to understand what's failing specifically."

---

### Q: "Can I use a different testing framework? I prefer xUnit/NUnit."

**Answer:**
"Yes, you can use xUnit or NUnit if you prefer! However, for validating the migration, you **must** keep the Python tests working since they verify API compatibility. The C# tests (MSTest, xUnit, or NUnit) are optional additions. The Python tests are your 'source of truth' for correctness."

---

### Q: "Do I need to write tests for every endpoint?"

**Answer:**
"The Python tests already test every endpoint through HTTP requests. For the workshop:

- **Required**: Keep Python tests passing (they validate your C# migration)
- **Optional**: Add C# unit tests (good practice, but not required for completion)

If you finish early, adding C# tests is a great Challenge!"

---

## Environment & Setup Questions

### Q: "Should I use Codespaces or local development?"

**Answer:**
"We recommend GitHub Codespaces for this workshop because:

- ✅ Zero setup - everything is pre-configured
- ✅ Consistent environment for everyone
- ✅ Works on any device with a browser
- ✅ No installation required

Local development is fine if you already have Python 3.12 and .NET 10 SDK installed and working."

---

### Q: "My Codespace is slow/frozen. What should I do?"

**Immediate Solutions:**

1. **Reload the page** - Often fixes temporary issues
2. **Stop and restart Codespace** - From GitHub Codespaces page
3. **Create a new Codespace** - Last resort, but effective

**Preventive Tips:**
- Close unused browser tabs
- Stop running processes when not needed
- Use `Ctrl+C` to stop running servers

**Answer to Give:**
"Let's try reloading the browser page first. If that doesn't help, we can restart your Codespace."

---

### Q: "Port 8000 is already in use. How do I fix this?"

**Solutions:**

**Find and kill the process:**

Windows PowerShell:
```powershell
# Find process
Get-NetTCPConnection -LocalPort 8000

# Kill process (replace PID)
Stop-Process -Id <PID> -Force
```

Linux/Mac:
```bash
# Find process
lsof -i :8000

# Kill process
kill -9 <PID>
```

**Or use a different port:**
```bash
# Python
uvicorn main:app --port 8001

# C#
dotnet run --urls "http://localhost:8001"
```

**Answer to Give:**
"Let's find what's using port 8000 and stop it. Or we can use a different port - just remember to update your BASE_URL environment variable for tests."

---

## Code Migration Questions

### Q: "How do I know which Copilot mode to use?"

**Quick Decision Guide:**

| Task | Mode | Why |
|------|------|-----|
| "What does this code do?" | **Ask** | Just learning, no changes |
| "Add error handling to this function" | **Edit** | Single, targeted change |
| "Create the C# scaffolding" | **Agent** | Multi-step task with commands |
| "What's the plan for migrating?" | **Plan** | Strategy before implementation |

**Answer to Give:**
"Use Ask for questions, Edit for small changes, Agent for multi-step tasks, and Plan when you need to think through the approach first."

---

### Q: "Can I migrate to a different language instead of C#?"

**Answer:**
"The workshop is designed specifically for Python to C# migration. However, the techniques you're learning (incremental migration, test-driven validation, using AI tools) apply to any language migration. After the workshop, you can try applying these patterns to migrate to Java, Go, Rust, or any language you prefer!"

---

### Q: "Why are we keeping the Python tests instead of rewriting them in C#?"

**Answer:**
"Great question! The Python tests serve as our 'source of truth' because:

1. **They test the original working implementation**
2. **They validate HTTP behavior** (what users actually see)
3. **They prove the new API is compatible** with the original
4. **Language-agnostic** - they work for any implementation

This is a real-world pattern: use the original tests to validate a rewrite."

---

## GitHub Copilot File References

### Q: "What does #file: mean in the prompts?"

**Answer:**
"The `#file:` syntax tells Copilot which specific file you're working with. Here's how to use it:

1. Type `#` in Copilot chat
2. A file picker appears
3. Select your file (like `Program.cs`)
4. Then type the rest of your prompt

This gives Copilot important context about your code structure."

**Demo:**
Show them: typing `#` → selecting file → adding prompt

---

### Q: "Do I have to use #file: every time?"

**Answer:**
"Not always! Use `#file:` when:

- Working with specific files (not currently open)
- Copilot needs context about a particular file
- You want very precise code generation

You don't need it for general questions or when the file is already open and selected."

---

## Time Management Questions

### Q: "I'm behind schedule. What should I skip?"

**Priority Order:**

1. **Must Complete** (Core Workshop):
   - Understanding the Python project ✅
   - Creating C# scaffolding ✅
   - Migrating at least 2-3 endpoints ✅
   - Getting Python tests passing ✅

2. **Should Complete** (Full Workshop):
   - All endpoints migrated
   - All Python tests passing
   - Understanding validation process

3. **Nice to Have** (If Time Permits):
   - C# unit tests
   - Code optimization
   - Challenge 1 or 2

**Answer to Give:**
"Focus on getting the scaffolding done and at least 2-3 endpoints working with tests passing. That covers the core concepts. You can finish the rest after the workshop."

---

### Q: "I finished early! What should I do?"

**Suggestions:**

1. **Try Challenge 1** (Containerization) - 🔥 Intermediate
2. **Try Challenge 2** (Database Integration) - 🔥🔥 Advanced
3. **Add C# Unit Tests** - Practice MSTest
4. **Optimize your code** - Ask Copilot about improvements
5. **Help a neighbor** - Teaching reinforces learning
6. **Experiment with different models** - Compare suggestions

**Answer to Give:**
"Great progress! Check out Challenge 1 or 2, or try adding C# unit tests. You could also experiment with different Copilot models to see how suggestions vary."

---

## General Troubleshooting

### Q: "Nothing is working. Can I start over?"

**Before Starting Over:**

1. Review recent changes with `git status` and `git diff`
2. Try reverting the last change: `git checkout -- <file>`
3. Check if it's a simple environment issue (port, path, etc.)
4. Ask a proctor to pair debug for 5 minutes

**If Starting Over:**
- Create a new Codespace (fresh environment)
- Or `git reset --hard` to last working commit
- Reference the completed example in `src/csharp-app-complete`

**Answer to Give:**
"Let's try to fix it first - starting over means losing your learning progress. Let me help debug for a few minutes."

---

## Pro Tips for Proctors

### When Someone is Stuck

1. **Ask them to explain the problem** - Often they'll solve it themselves
2. **Check the basics first** - App running? Right directory? File saved?
3. **Look at error messages together** - Teach debugging skills
4. **Use Copilot to help** - Show them how to ask Copilot about the error
5. **Pair debug** - Walk through it together rather than fixing it for them

### When Multiple People Have the Same Issue

- Pause and do a group explanation
- Add it to "Common Issues" board
- Update the troubleshooting doc
- Consider if the instructions need clarification

### Encourage Good Habits

- ✅ Validate after each change
- ✅ Read error messages carefully
- ✅ Use Copilot to explain errors
- ✅ Test incrementally
- ✅ Ask questions early

---

## Quick Reference Card

Print or display this for easy reference:

```
COPILOT NOT WORKING?
→ Check status bar icon
→ Reload window
→ Save file first

TESTS FAILING?
→ Is app running?
→ Right port (8000)?
→ Check BASE_URL env var

PORT IN USE?
→ lsof -i :8000 (find)
→ kill -9 <PID> (stop)
→ Or use different port

STUCK?
→ Check error message
→ Ask Copilot about error
→ Review test output
→ Check basics (path, port)

FINISHED EARLY?
→ Try Challenge 1 or 2
→ Add C# unit tests
→ Help a neighbor
```
