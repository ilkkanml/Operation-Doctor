# Operation: Doctor — Stage 13 Validation Boundary

## Purpose
This document closes the remaining Stage 13 QA boundary items.

## Minimum Loop Validation
The minimum loop must remain small and testable.

Expected flow:
```text
Queue visible
→ Profile selected
→ Action selected
→ Result state shown
→ Decision made
→ Reward feedback shown
```

## UI Boundary
Stage 13 UI planning may define these areas only:
- Queue panel
- Profile card
- Action button area
- Result feedback area
- Reward feedback area

Excluded:
- Final art pass
- Full animation pass
- Advanced staff UI
- Room UI
- Economy UI

## Data Boundary
Stage 13 data planning may define sample data groups only:
- visitor sample
- condition sample
- action sample
- result sample
- reward sample

No full catalog production is allowed in Stage 13.

## Validation Boundary
Validation checks only whether the planned flow is clear.

Checklist:
- Queue state is defined.
- Profile card state is defined.
- Action selection state is defined.
- Result-ready state is defined.
- Reward feedback state is defined.
- No prototype or gameplay code is included.

## QA Rule
If any item is unclear, Stage 13 must not move to implementation.

## Next Step
After Stage 13 freeze, Stage 14 may plan first playable implementation tasks.
