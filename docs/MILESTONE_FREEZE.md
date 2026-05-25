# Operation: Doctor — Milestone Freeze Log

## Freeze Rule
A milestone can be frozen only after department review, required support issues, no critical open conflict, and handoff update.

## Active Milestone
Milestone 4 — Test Timer & Equipment Levels

Status: Milestone 3 frozen. Milestone 4 is next active milestone.

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
- Do not open Milestone 5 before Milestone 4 is complete.
- Update handoff after every freeze.
- Close duplicate issues when found.
