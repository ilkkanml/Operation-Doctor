# Operation: Doctor — Handoff

## Purpose
This file carries project state between chats, agent sessions, and GitHub issue flows.

## Current Status (2026-05-25)
Project: Operation: Doctor
Stage: Stage 15 — Controlled Codex Handoff
Status: Stage 14 is frozen. Stage 15 is active with controlled, docs-first tasks only.

## Repository
`https://github.com/ilkkanml/Operation-Doctor.git`

## Stage 15 Completed Controlled Items
- PR #47 merged: controlled handoff checklist + first task scope lock.
- Issue #48 completed: WP-15-01 Shell Readiness and First Playable Mapping.
- PR #49 merged: WP-15-01 gate validation report.
- Issue #50 completed: WP-15-02 First Playable Data Contract Draft.
- PR #51 merged: WP-15-02 data contract draft (docs-only).

## Active Boundaries
- No full production start.
- No scope expansion.
- No implementation outside Unity shell + first playable boundary.
- No production art/audio/release pipeline work.
- Use Stage 14 sample data and Stage 15 controlled docs as source of truth.

## Current Source Documents
1. `docs/MILESTONE_FREEZE.md`
2. `docs/ENGINE_DECISION.md`
3. `docs/STAGE_14_IMPLEMENTATION_PLAN.md`
4. `docs/STAGE_15_CONTROLLED_HANDOFF_CHECKLIST.md`
5. `docs/STAGE_15_FIRST_TASK_SCOPE.md`
6. `docs/STAGE_15_WP_15_01_GATE_REPORT.md`
7. `docs/STAGE_15_WP_15_02_DATA_CONTRACT_DRAFT.md`
8. `docs/DECISIONS.md`

## Clarification
- Unity engine decision is approved.
- Any older notes saying engine is not selected are obsolete.

## Open Risks
- Scope creep requests can bypass boundary unless each task is gate-checked.
- Boundary confusion between docs planning and runtime coding can cause early production drift.

## Next Controlled Step
WP-15-03: sync HANDOFF and DECISIONS records, then continue with the next docs-only controlled task.
