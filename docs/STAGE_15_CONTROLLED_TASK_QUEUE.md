# Operation: Doctor — Stage 15 Controlled Task Queue

## Purpose
Provide one ordered queue for controlled Stage 15 tasks and define hard stop conditions.

## Stage 15 Rule
All tasks must stay docs-only or shell-safe until Stage 15 exit criteria is approved.

## Task Queue

### Completed
1. WP-15-01 — Shell readiness and first playable mapping
- Result: gate report completed (`docs/STAGE_15_WP_15_01_GATE_REPORT.md`)

2. WP-15-02 — First playable data contract draft
- Result: data contract draft completed (`docs/STAGE_15_WP_15_02_DATA_CONTRACT_DRAFT.md`)

3. WP-15-03 — Handoff and decisions sync
- Result: `docs/HANDOFF.md` and `docs/DECISIONS.md` synchronized

4. WP-15-04 — Controlled task template and review gate
- Result: reusable task template + review gate checklist added

### Planned
5. WP-15-05 — Controlled task queue and stop conditions
- Result target: this file

6. WP-15-06 — Stage 15 consolidation summary
- Result target: single summary of completed controlled outputs and open risks

7. WP-15-07 — Stage transition readiness check
- Result target: explicit pass/fail checklist for moving beyond Stage 15

## Per-Task Done Criteria
A WP is done only if:
- a scoped issue exists,
- a small docs-only PR is merged,
- review gate checklist is satisfied,
- no boundary violation is introduced.

## Hard Stop Conditions
Stop task execution immediately if any request includes:
- gameplay/runtime production coding,
- full production start,
- advanced systems outside first playable boundary,
- final art/audio/release workflow setup,
- uncontrolled scope expansion.

## Fail Handling
If a stop condition is triggered:
1. Do not merge current oversized changes.
2. Split request into a new scoped issue.
3. Return to Stage 15 template + review gate documents.
4. Update handoff/decisions if boundary policy changes.

## Stage 15 Exit Readiness (Preliminary)
Stage transition can be considered only if:
- all planned Stage 15 controlled WPs are complete,
- handoff and decisions are current,
- no open boundary breach exists,
- user approval is explicit.
