# Operation: Doctor — Stage 13 Work Package Breakdown

## Purpose
This document defines the first playable work package breakdown.

## Stage 13 Boundary
Stage 13 is planning only.

Included:
- Work package grouping
- Minimum loop items
- UI boundary
- Data boundary
- Check boundary
- Testable package definitions

Excluded:
- Full production
- Gameplay prototype creation
- Production art
- Production audio
- Store/release preparation

## Minimum Loop Items
```text
Visitor enters
→ Queue visible
→ Profile card visible
→ Action selected
→ Result-ready state
→ Basic decision
→ Simple reward trigger
```

## Work Package Groups

### WP-01 — Core Loop Package
Covers the smallest playable flow.

Includes:
- Queue state
- Profile card state
- Action selection state
- Result-ready state
- Completion state

### WP-02 — UI Boundary Package
Defines what UI must show, without final art.

Includes:
- Queue area
- Profile card panel
- Action buttons
- Result feedback
- Reward feedback

### WP-03 — Data Boundary Package
Defines which data groups are required for the first playable.

Includes:
- Visitor sample data
- Condition sample data
- Action sample data
- Reward sample data

### WP-04 — Validation Package
Defines how the first playable will be checked.

Includes:
- Flow checklist
- Data loading checklist
- UI readability checklist
- No scope creep checklist

## Scope Guard
Do not include:
- Advanced staff systems
- Room systems
- Follow-up systems
- Optional economy systems
- Full content catalogs

## Next Step
Run QA review before freezing Stage 13.
