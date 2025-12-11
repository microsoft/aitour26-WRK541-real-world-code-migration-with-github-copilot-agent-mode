# Attendee Progress Tracker Template

This template helps proctors track attendee progress during the workshop and identify when to adjust pacing or provide additional support.

## Workshop Progress Checkpoints

Use this template during the workshop to track how many attendees have completed each major milestone. This helps you:

- Know when to move forward vs slow down
- Identify who needs additional help
- Adjust timing for remaining sections
- Provide targeted assistance

---

## Quick Progress Tracker

**Workshop Date:** ________________  
**Total Attendees:** ______  
**Proctors:** ________________

### Checkpoint 1: Environment Setup (Target: 10 minutes)

**Time Check:** ______

"Show of hands: Who has their environment ready?"

- [ ] Codespace/Local environment running: ______ / ______
- [ ] VS Code opened: ______ / ______
- [ ] GitHub Copilot working: ______ / ______

**Status:**  
☐ >80% ready → Proceed  
☐ 60-80% ready → Give 5 more minutes  
☐ <60% ready → Group troubleshooting needed  

**Notes:** ___________________________________________

---

### Checkpoint 2: Python App Running (Target: 25 minutes)

**Time Check:** ______

"Show of hands: Who has the Python app running and tested?"

- [ ] Python app started successfully: ______ / ______
- [ ] Accessed Swagger UI: ______ / ______
- [ ] Ran Python tests (pytest): ______ / ______

**Status:**  
☐ >80% ready → Proceed to C# scaffolding  
☐ 60-80% ready → Pair struggling attendees  
☐ <60% ready → Group demo needed  

**Common Issues Seen:**
- [ ] Dependencies not installed
- [ ] Wrong directory
- [ ] Port already in use
- [ ] Other: _________________

**Notes:** ___________________________________________

---

### Checkpoint 3: C# Scaffolding Created (Target: 40 minutes)

**Time Check:** ______

"Show of hands: Who has C# scaffolding created?"

- [ ] csharp-app folder created: ______ / ______
- [ ] .csproj file present: ______ / ______
- [ ] Program.cs created: ______ / ______
- [ ] Can run `dotnet build`: ______ / ______

**Status:**  
☐ >80% ready → Proceed to first endpoint  
☐ 60-80% ready → Provide template/guidance  
☐ <60% ready → Consider demo  

**Notes:** ___________________________________________

---

### Checkpoint 4: First Endpoint Working (Target: 55 minutes)

**Time Check:** ______

"Show of hands: Who has the root endpoint (/) working?"

- [ ] Root endpoint implemented: ______ / ______
- [ ] C# app runs on port 8000: ______ / ______
- [ ] Python test for root passes: ______ / ______

**Status:**  
☐ >80% ready → Proceed to remaining endpoints  
☐ 60-80% ready → Quick troubleshooting break  
☐ <60% ready → Review validation process  

**Common Issues Seen:**
- [ ] Port configuration wrong
- [ ] Tests not finding running app
- [ ] JSON serialization problems
- [ ] Other: _________________

**Notes:** ___________________________________________

---

### Checkpoint 5: All Endpoints Migrated (Target: 70 minutes)

**Time Check:** ______

"Show of hands: Who has all endpoints migrated with Python tests passing?"

- [ ] All endpoints implemented: ______ / ______
- [ ] All Python tests passing: ______ / ______
- [ ] Swagger documentation working: ______ / ______

**Status:**  
☐ >80% complete → Move to wrap-up/challenges  
☐ 60-80% complete → Those done can start Challenge 1  
☐ <60% complete → Extend time or prioritize core endpoints  

**Notes:** ___________________________________________

---

### Final Status: Workshop Completion

**Time Check:** ______

"Show of hands: Where are you at?"

- [ ] Completed core workshop (all endpoints): ______ / ______
- [ ] Completed most (3+ endpoints working): ______ / ______
- [ ] Partial completion (1-2 endpoints): ______ / ______
- [ ] Started Challenge 1 or 2: ______ / ______
- [ ] Added C# tests: ______ / ______

**Overall Success Rate:** ______%

**Notes:** ___________________________________________

---

## Detailed Tracking Sheet

For workshops with assigned seating or when you need detailed tracking:

| Attendee # | Name | Env Ready | Python Running | Scaffolding | 1st Endpoint | All Endpoints | Notes |
|------------|------|-----------|----------------|-------------|--------------|---------------|-------|
| 1 | | ☐ | ☐ | ☐ | ☐ | ☐ | |
| 2 | | ☐ | ☐ | ☐ | ☐ | ☐ | |
| 3 | | ☐ | ☐ | ☐ | ☐ | ☐ | |
| 4 | | ☐ | ☐ | ☐ | ☐ | ☐ | |
| 5 | | ☐ | ☐ | ☐ | ☐ | ☐ | |
| 6 | | ☐ | ☐ | ☐ | ☐ | ☐ | |
| 7 | | ☐ | ☐ | ☐ | ☐ | ☐ | |
| 8 | | ☐ | ☐ | ☐ | ☐ | ☐ | |
| 9 | | ☐ | ☐ | ☐ | ☐ | ☐ | |
| 10 | | ☐ | ☐ | ☐ | ☐ | ☐ | |

*(Continue as needed for your workshop size)*

---

## Pacing Decision Matrix

Use this guide to decide whether to proceed or pause:

### When 80%+ Complete
✅ **Proceed to next section**
- Quick recap for those ready
- Assign helpers to assist remaining attendees
- Those who finish can move ahead to challenges

### When 60-79% Complete
⚠️ **Provide 5-10 more minutes**
- Announce: "Let's take 5 more minutes on this checkpoint"
- Pair advanced attendees with those who need help
- Circulate to provide targeted assistance

### When <60% Complete
🛑 **Group intervention needed**
- Pause the workshop
- Do a group demo/explanation
- Address common issues publicly
- Reset timeline if needed

---

## Issue Tracking

Track issues as they arise to identify patterns:

| Time | Issue Description | # Affected | Resolution | Time to Fix |
|------|------------------|------------|------------|-------------|
| | | | | |
| | | | | |
| | | | | |
| | | | | |
| | | | | |

**Pattern Analysis:**

- Most common issue: ________________
- Average resolution time: ______
- Issues requiring group explanation: ________________

---

## Timing Adjustments

If you're behind schedule, use this priority guide:

### Must Cover (Core Learning Objectives)
- [ ] Understanding Python project structure
- [ ] Creating C# scaffolding with Agent mode
- [ ] Implementing at least 2 endpoints
- [ ] Validating with Python tests
- [ ] Understanding Copilot modes

### Should Cover (Complete Workshop)
- [ ] All endpoints migrated
- [ ] All tests passing
- [ ] Code optimization discussion

### Nice to Have (If Time Permits)
- [ ] C# unit tests
- [ ] Challenge 1 introduction
- [ ] Challenge 2 discussion

**Recommendation:** If running behind, focus on quality over quantity. Better to have 2-3 endpoints fully understood than rush through all endpoints.

---

## Post-Workshop Summary

**Date:** ________________  
**Duration:** ______ hours ______ minutes  

**Completion Rates:**
- Full completion (all endpoints): ______%
- Partial completion (2+ endpoints): ______%
- Started but incomplete: ______%

**Pace Assessment:**
☐ Too fast - many struggled to keep up  
☐ Just right - most completed with good understanding  
☐ Too slow - many finished early and were idle  

**Most Effective Sections:**
1. ________________
2. ________________
3. ________________

**Sections That Need Improvement:**
1. ________________
2. ________________
3. ________________

**Technical Issues Summary:**
- Most frequent issue: ________________
- Biggest time sink: ________________
- Unexpected issues: ________________

**Recommendations for Next Session:**
1. ________________
2. ________________
3. ________________

**Attendee Feedback Highlights:**
- Positive: ________________
- Suggestions: ________________
- Concerns: ________________

---

## Quick Check Phrases

Use these during the workshop for quick pulse checks:

**Environment Check:**
> "Quick show of hands: Green light - everything working. Yellow - minor issues. Red - blocked."

**Comprehension Check:**
> "Thumbs up if that makes sense, thumbs down if you need more explanation."

**Progress Check:**
> "Let's see where everyone is. Hands up if you have [checkpoint] completed."

**Pacing Check:**
> "Quick pulse check: Are we moving too fast, too slow, or just right?"

**Energy Check:**
> "How's everyone doing? Need a quick break?"

---

## Digital Tracking Alternative

If you prefer digital tracking, consider using:

**Spreadsheet (Google Sheets):**
- Share with all proctors
- Real-time updates
- Easy to analyze after

**Simple Form:**
- Create a Google Form
- Attendees self-report progress
- Quick aggregate view

**Polling Tool:**
- Mentimeter, Slido, or Poll Everywhere
- Anonymous responses
- Visual results

**Example Google Sheet Structure:**
```
Column A: Attendee ID
Column B: Checkpoint 1 (Y/N)
Column C: Checkpoint 2 (Y/N)
Column D: Checkpoint 3 (Y/N)
Column E: Checkpoint 4 (Y/N)
Column F: Checkpoint 5 (Y/N)
Column G: Notes
```

---

## Tips for Effective Progress Tracking

1. **Check frequently** - Every 15-20 minutes at minimum
2. **Be visible** - Make it easy for attendees to signal for help
3. **Use helpers** - Advanced attendees can assist others
4. **Stay flexible** - Adjust pace based on real-time data
5. **Document** - Notes help improve future workshops

**Remember:** Progress tracking is not about judging attendees - it's about ensuring everyone has a successful learning experience.
