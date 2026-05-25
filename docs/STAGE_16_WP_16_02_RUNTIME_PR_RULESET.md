# Operation: Doctor — Stage 16 WP-16-02 Runtime PR Ruleset

## Purpose
Set mandatory rules before opening the first runtime implementation PR.

## Task Type
Docs-only governance rule set.

## Mandatory Preconditions
1. `docs/STAGE_16_WP_16_01_FIRST_SLICE_TASK.md` is approved and current.
2. Stage 16 entry gates in `docs/STAGE_16_ENTRY_PLAN.md` are all checked.
3. Review gate checklist is attached to the runtime task.
4. Runtime task is split into a small, reversible PR scope.

## Allowed Scope for First Runtime PR
- Placeholder-safe implementation only.
- First playable boundary only: queue/profile/action/result/reward flow support.
- Minimal path set only:
  - `Assets/Scenes/`
  - `Assets/Scripts/Placeholder/`
  - `Assets/Data/PlaceholderData/`
  - `Assets/UI/`

## Disallowed Scope
- Advanced systems (staff, room, follow-up, economy).
- Full production architecture expansion.
- Production art/audio/release workflow.
- Broad refactors not required by first slice.

## Required PR Sections
Every first runtime PR must include:
- Objective
- In-scope / out-of-scope
- File boundary list
- Review gate pass/fail checklist
- Rollback plan

## Fail / Stop Conditions
Stop and do not merge if:
- file changes exceed allowed path boundary,
- implementation includes advanced systems,
- PR cannot be reviewed in one small pass,
- review gate has any FAIL item.

## Rollback Action
If stop condition is hit:
1. Close or convert PR to draft.
2. Split work into smaller scoped tasks.
3. Return to docs-first correction task.
4. Update handoff/decision logs if boundary policy changes.

## Outcome
No runtime PR should open without satisfying this ruleset.
