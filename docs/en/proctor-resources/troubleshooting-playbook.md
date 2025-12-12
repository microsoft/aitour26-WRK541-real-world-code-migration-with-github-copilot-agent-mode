# Proctor Troubleshooting Playbook

This playbook provides proctors with quick solutions to common technical issues that arise during the workshop. Use this for fast issue resolution and to minimize disruption to the workshop flow.

## 🚨 Critical Issues (Immediate Action Required)

### Issue: Attendee's Codespace Won't Start

**Symptoms:**
- Codespace stuck on "Starting..."
- Error message during Codespace creation
- Codespace starts but immediately stops

**Solution Steps:**

1. **Check GitHub Status** (30 seconds)
   - Visit [githubstatus.com](https://githubstatus.com)
   - If Codespaces are down, switch to local development guide

2. **Try Different Browser** (1 minute)
   - Sometimes browser extensions interfere
   - Try incognito/private mode
   - Chrome and Edge work best

3. **Delete and Recreate** (2 minutes)
   ```
   1. Go to github.com/codespaces
   2. Delete the problematic Codespace
   3. Return to repository
   4. Click "Code" → "Codespaces" → "New codespace"
   ```

4. **Fallback to Local** (if issue persists)
   - Guide attendee to PREREQUISITES.md
   - Have them clone repository locally
   - Verify Python 3.12 and .NET 10 SDK installed

**Prevention:**
- Before workshop: Test Codespaces creation yourself
- Have local development guide ready as backup

---

### Issue: Copilot Not Activated/Working

**Symptoms:**
- Copilot icon shows error
- No suggestions appearing
- "Copilot is not available" message

**Solution Steps:**

1. **Check Copilot Status** (30 seconds)
   ```
   - Look at status bar (bottom of VS Code)
   - Copilot icon should show without red X
   - Click icon to see detailed status
   ```

2. **Verify Subscription** (1 minute)
   ```
   - Go to github.com/settings/copilot
   - Verify active subscription/trial
   - Check if it expired today
   ```

3. **Re-authenticate** (2 minutes)
   ```
   1. Ctrl+Shift+P → "Sign out of GitHub"
   2. Wait 10 seconds
   3. Ctrl+Shift+P → "Sign in to GitHub"
   4. Complete authentication flow
   ```

4. **Reload VS Code** (30 seconds)
   ```
   Ctrl+Shift+P → "Reload Window"
   ```

5. **Check Extensions** (1 minute)
   ```
   - Verify GitHub Copilot extension installed
   - Verify GitHub Copilot Chat extension installed
   - Update extensions if updates available
   ```

**Workaround:**
- If Copilot Chat works but inline doesn't (or vice versa), use whichever works
- They can complete workshop with Chat alone

**Prevention:**
- In pre-workshop email: Remind attendees to verify Copilot access
- Have them test Copilot before workshop day

---

### Issue: Widespread Test Failures (Multiple Attendees)

**Symptoms:**
- Many attendees reporting same test failing
- Pattern of failures across the room

**Root Causes & Solutions:**

1. **App Not Running** (Most Common)
   ```
   Solution: Remind everyone to start the app first
   
   Terminal 1:
   cd src/csharp-app
   dotnet run --urls "http://localhost:8000"
   
   Terminal 2:
   cd src/python-app/webapp
   pytest test_main.py -v
   ```

2. **Wrong Port**
   ```
   Solution: Check they're using port 8000
   
   # When running C# app:
   dotnet run --urls "http://localhost:8000"
   
   # Not:
   dotnet run  # (uses port 5000 by default)
   ```

3. **Environment Variable Not Set**
   ```
   Solution: Set BASE_URL if needed
   
   Windows PowerShell:
   $env:BASE_URL="http://localhost:8000"
   
   Linux/Mac:
   export BASE_URL="http://localhost:8000"
   ```

**Quick Check Announcement:**
```
"If tests are failing, please verify:
1. Is your app running in a terminal?
2. Is it on port 8000?
3. Can you curl http://localhost:8000 and get a response?
Let me know if you still have issues after checking these."
```

---

### Issue: Internet Connectivity Problems

**Symptoms:**
- Can't access GitHub
- Copilot not responding
- Package installations failing

**Solution Steps:**

1. **Verify Connectivity** (1 minute)
   ```bash
   ping github.com
   curl https://api.github.com
   ```

2. **Check Proxy/Firewall** (if in corporate environment)
   - Ask venue IT about proxy settings
   - May need to configure git/npm proxy

3. **Use Offline Mode** (Fallback)
   ```
   - Reference completed code in src/csharp-app-complete
   - Work from printed materials if available
   - Pair with someone with working connection
   ```

**Prevention:**
- Test venue WiFi before workshop
- Have offline materials ready (completed code, printed guides)
- Consider mobile hotspot as backup

---

## ⚠️ Common Issues (Frequent but Non-Critical)

### Issue: Port 8000 Already in Use

**Symptoms:**
- Error: "Address already in use"
- Can't start app on port 8000

**Solution:**

**Windows PowerShell:**
```powershell
# Find what's using port 8000
Get-NetTCPConnection -LocalPort 8000

# Kill the process (replace <PID>)
Stop-Process -Id <PID> -Force
```

**Linux/Mac:**
```bash
# Find what's using port 8000
lsof -i :8000

# Kill the process
kill -9 <PID>
```

**Alternative:**
```bash
# Use a different port
dotnet run --urls "http://localhost:8001"

# Remember to update BASE_URL
export BASE_URL="http://localhost:8001"
```

---

### Issue: Python Dependencies Not Installed

**Symptoms:**
- `ModuleNotFoundError: No module named 'fastapi'`
- Import errors when running Python app

**Solution:**
```bash
cd src/python-app/webapp
pip3 install -r ../requirements.txt

# Or in parent directory:
cd src/python-app
pip3 install -r requirements.txt
```

**Verify:**
```bash
pip3 list | grep fastapi
# Should show fastapi==0.103.2
```

---

### Issue: .NET SDK Not Found (Local Development)

**Symptoms:**
- `dotnet: command not found`
- `The specified SDK version is not available`

**Solution:**

1. **Verify Installation:**
   ```bash
   dotnet --version
   # Should show 10.0.x
   ```

2. **If Not Installed:**
   - Send them to: https://dotnet.microsoft.com/download/dotnet/10.0
   - Download and install .NET 10 SDK
   - Restart terminal/VS Code after installation

3. **Path Issues:**
   ```bash
   # Add to PATH if needed
   export PATH="$PATH:/usr/share/dotnet"
   ```

---

### Issue: JSON Deserialization Errors

**Symptoms:**
- Error reading weather.json
- Null reference exceptions
- Data not loading

**Common Causes:**

1. **File Path Wrong:**
   ```csharp
   // Wrong (might not work when running from different directory)
   var json = File.ReadAllText("weather.json");
   
   // Better
   var json = File.ReadAllText("weather.json");  // In same directory
   // Or use full path from project root
   ```

2. **JSON Format Issues:**
   - Check weather.json is valid JSON
   - Verify model classes match JSON structure

3. **Encoding Issues:**
   - Use UTF8: `File.ReadAllText("weather.json", Encoding.UTF8)`

**Quick Fix:**
```csharp
// Add null checks
if (weatherData == null)
{
    return Results.Problem("Failed to load weather data");
}
```

---

### Issue: VS Code Not Showing Copilot Chat

**Symptoms:**
- Chat icon missing
- Can't open Copilot Chat panel
- Extension installed but not visible

**Solution:**

1. **Open Chat Panel:**
   ```
   Ctrl+Alt+I (Windows/Linux)
   Cmd+Shift+I (Mac)
   
   Or: View → Command Palette → "GitHub Copilot: Open Chat"
   ```

2. **Check Extension:**
   ```
   Extensions → Search "GitHub Copilot Chat"
   Should show as installed and enabled
   If not, install it
   ```

3. **Reload Window:**
   ```
   Ctrl+Shift+P → "Reload Window"
   ```

---

### Issue: Tests Pass Locally But Not in CI/CD

**Not applicable for this workshop, but good to know:**

**Common Causes:**
- Environment differences
- Port conflicts in CI
- Timing issues (app not fully started)

**For Workshop:**
- We're not using CI/CD
- Tests run locally only
- If mentioned, explain this is out of scope

---

## 🛠️ Debugging Techniques for Proctors

### The 5-Minute Debug Protocol

When an attendee is stuck, use this systematic approach:

1. **Understand the Problem (1 min)**
   - Ask them to describe what they're trying to do
   - What error are they seeing?
   - What was the last thing that worked?

2. **Check the Basics (1 min)**
   - Is the app running?
   - Right directory? (`pwd`)
   - File saved?
   - Right port?

3. **Read the Error (1 min)**
   - Look at actual error message together
   - Identify the specific line/file
   - Google the error if needed

4. **Test Hypothesis (1 min)**
   - Make one small change
   - Test immediately
   - Observe result

5. **Iterate or Escalate (1 min)**
   - If improving: continue debugging
   - If stuck: escalate to lead instructor
   - If solved: document the issue

### Using Copilot for Debugging

**Teach attendees to ask Copilot:**
```
"I'm getting this error: [paste error message]
Here's my code: [paste code]
What's wrong and how do I fix it?"
```

This teaches them a valuable skill while solving their problem.

---

## 📊 Tracking Issues During Workshop

### Issue Log Template

Keep a running log during workshop:

```
Time | Issue | Attendees Affected | Solution | Time to Resolve
-----|-------|-------------------|----------|----------------
9:15 | Port 8000 in use | 3 | Kill process | 2 min
9:30 | Copilot not working | 1 | Re-auth | 5 min
9:45 | Tests failing | 5 | App not running | 1 min
```

**Use This To:**
- Identify patterns (same issue multiple times = needs announcement)
- Time management (if resolving issues taking too long)
- Improve materials (frequent issues need better docs)

---

## 🎯 Proactive Issue Prevention

### Pre-Workshop Checks (1 hour before)

- [ ] Test Codespaces creation
- [ ] Verify GitHub.com is accessible
- [ ] Test Copilot in a fresh Codespace
- [ ] Run through first 3 workshop steps
- [ ] Verify all links in documentation work
- [ ] Check venue WiFi quality

### Opening Announcements

**Before starting:**
```
"A few technical tips before we begin:

1. If you see errors, READ the error message - it usually tells you what's wrong
2. If tests fail, make sure your app is running first
3. If Copilot isn't working, check the status bar icon
4. Save your files before asking Copilot for help
5. Don't hesitate to ask for help - that's what we're here for!

Any questions before we start?"
```

### Mid-Workshop Checkpoints

**After major sections:**
```
"Let's do a quick checkpoint. Raise your hand if:
- Your Python app is running and tested ✓
- You've created C# scaffolding ✓
- You have at least one C# endpoint working ✓

If you don't have your hand up, let's pause and get everyone caught up."
```

---

## 🚀 Quick Command Reference

### For Proctors to Help Attendees Quickly

**Check Running Processes:**
```bash
# See what's running on port 8000
lsof -i :8000          # Mac/Linux
netstat -ano | findstr :8000  # Windows

# See all running processes
ps aux | grep python   # Python processes
ps aux | grep dotnet   # .NET processes
```

**Kill Processes:**
```bash
# By PID
kill -9 <PID>          # Mac/Linux
Stop-Process -Id <PID> -Force  # Windows PowerShell

# By name (careful!)
pkill python           # Kill all Python
pkill dotnet           # Kill all .NET
```

**Check Installations:**
```bash
python3 --version      # Should be 3.12.x
dotnet --version       # Should be 10.0.x
git --version          # Any recent version
code --version         # VS Code version
```

**Test Endpoints:**
```bash
# Test if app is responding
curl http://localhost:8000
curl http://localhost:8000/countries

# Formatted output
curl http://localhost:8000/countries | jq
```

**Git Helpers:**
```bash
# See what changed
git status
git diff

# Undo changes
git checkout -- <file>
git reset --hard HEAD

# See completed code
ls src/csharp-app-complete
```

---

## 📞 Escalation Guide

### When to Escalate to Lead Instructor

- Issue affects multiple attendees (>3)
- Issue blocks forward progress
- Security/access problem
- Venue/equipment problem
- Attendee has spent >10 minutes on same issue

### When to Suggest Moving On

- Issue is in "nice to have" territory
- Time is limited
- Alternative approach exists
- Can complete workshop without resolving it

**Phrase it positively:**
```
"Let's move forward and circle back to this later. You can finish
the workshop and then tackle this specific issue. Would that work?"
```

---

## 💡 Pro Tips

### For New Proctors

1. **Don't just fix it** - Teach them to debug
2. **Use Copilot** - Show them how to ask Copilot about errors
3. **Stay calm** - Technical issues are normal
4. **Document** - Note new issues for future workshops
5. **Time-box** - Don't spend more than 5 min on one issue

### For Experienced Proctors

1. **Anticipate** - Watch for common issues before they're reported
2. **Group solve** - If same issue hits 3+ people, do a group explanation
3. **Empower** - Teach attendees to help each other
4. **Improve** - Suggest doc improvements for issues you see repeatedly
5. **Share** - Brief other proctors on patterns you notice

---

## Summary

**Most Common Issues (in order of frequency):**

1. App not running when tests executed
2. Wrong port (not 8000)
3. Copilot not authenticated
4. Port 8000 already in use
5. Dependencies not installed

**Quick Fixes:**
- 90% of issues solved by: checking app is running, verifying port, reloading window
- When in doubt: read the error message carefully
- Use Copilot to explain errors - teaches debugging skill

**Remember:**
- Technical issues are learning opportunities
- Stay patient and positive
- Document new issues
- Share insights with other proctors
