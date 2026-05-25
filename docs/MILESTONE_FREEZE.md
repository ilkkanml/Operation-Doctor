# Operation: Doctor — Milestone Freeze Log

## Freeze Rule
A milestone can be frozen only after department review, required support issues, no critical open conflict, and handoff update.

## Active Milestone
Milestone 9 — Patient Rooms & Recovery

Status: Milestone 8 frozen. Milestone 9 is next active milestone.

## Freeze Records

### Milestone 0 — Foundation Documents
```text
Date: 2026-05-23
Issue: #2
Approver: Studio Director
Decision: Approved for freeze.
Scope: Project governance, bible, handoff, freeze log, decisions log, department rules, orchestrator, department prompts, start files, inspiration reference.
Risk: Scope drift must be controlled.
Next: Milestone 1.
```

### Milestone 1 — Core Patient Flow
```text
Date: 2026-05-24
Issue: #3
Support Issues: #18, #19
Approvers: Studio Director, Clinical Content Designer, Game & Systems Designer
Decision: Approved for freeze.
Scope: Intake flow, priority rules, basic selection, start action flow, minimal timing and feedback.
Risk: Early flow may feel too simple. Expand carefully later.
Next: Milestone 2.
```

### Milestone 2 — Basic Exam & Diagnosis
```text
Date: 2026-05-24
Issue: #11
Support Issues: #20
Approvers: Studio Director, Game & Systems Designer
Decision: Approved for freeze.
Scope: Basic exam-result-decision loop, ready state, decision gate, XP and money reward trigger.
Risk: Reward tuning may need later balancing.
Next: Milestone 3.
```

### Milestone 3 — Manual Department Routing
```text
Date: 2026-05-24
Issue: #12
Support Issues: #21
Approvers: Studio Director, QA & Release Director
Decision: Approved for freeze if no blocking UX or flow issue is present.
Scope: Manual routing flow, service room selection, queue readability, capacity readability, result-ready feedback, Milestone 1-2 regression safety.
Risk: Queue/capacity UI can confuse players if not readable. Result-ready feedback must be obvious.
Next: Milestone 4.
```

### Milestone 4 — Test Timer & Equipment Levels
```text
Date: 2026-05-24
Issue: #13
Support Issues: #22
Approvers: Studio Director, QA & Release Director
Decision: Approved for freeze if timer readability, ready feedback, equipment level clarity, and regression safety are satisfied.
Scope: Basic test timer, result-ready feedback, equipment level effect clarity, Milestone 1-3 flow compatibility.
Risk: Timer or equipment effect may be unclear if UI feedback is weak.
Next: Milestone 5.
```

### Milestone 5 — First Assistant System
```text
Date: 2026-05-24
Issue: #14
Support Issues: #23, #24
Approvers: Studio Director, Game & Systems Designer, QA & Release Director
Decision: Approved for freeze if unlock, selection, cost, skill info, and assignment flow are clear.
Scope: First hiring unlock, selection flow, salary/cost visibility, readable skill info, one-department assignment rule. Shift/rest is excluded.
Risk: If cost or skill info is unclear, player decisions can feel random. Future systems must not appear early.
Next: Milestone 6.
```

### Milestone 6 — Staff Skill, Shift & Rest
```text
Date: 2026-05-24
Issue: #15
Support Issues: #25
Approvers: Studio Director, QA & Release Director
Decision: Approved for freeze if skill gain, shift, energy, fatigue, rest area, and training slot rules are readable and no Milestone 7 systems are included.
Scope: Staff skill gain, shift rule, energy state, fatigue state, rest area rule, training slot rule.
Risk: If staff state values are unclear, the management layer can feel confusing. Milestone 7 capacity systems must not appear early.
Next: Milestone 7.
```

### Milestone 7 — Department Capacity
```text
Date: 2026-05-24
Issue: #16
Support Issues: #26
Approvers: Studio Director, QA & Release Director
Decision: Approved for freeze if capacity, queue, upgrade, and combined effects are readable and no Milestone 8 systems are included.
Scope: Department capacity rule, queue rule, capacity upgrade rule, staff/device/room effect clarity, patient-flow balance.
Risk: Capacity and queue UI can confuse players if not clearly explained. Milestone 8 follow-up systems must not appear early.
Next: Milestone 8.
```

### Milestone 8 — Appointment & Follow-Up
```text
Date: 2026-05-24
Issue: #10
Support Issues: #27
Approvers: Studio Director, QA & Release Director
Decision: Approved for freeze if follow-up, appointment, return visit, progress tracking, reward impact, and Milestone 9 exclusion are clear.
Scope: Follow-up rule, appointment rule, return visit flow, progress tracking, reward impact, Milestone 9 exclusion.
Risk: If follow-up and appointment states are not readable, players may miss return visits. Milestone 9 room/recovery systems must not appear early.
Next: Milestone 9.
```

## Freeze Record Format
```text
Milestone:
Date:
Issue / PR:
Approver:
Scope:
Risk:
Next:
```

## Next Notes
- Do not open Milestone 10 before Milestone 9 is complete.
- Update handoff after every freeze.
- Close duplicate issues when found.
