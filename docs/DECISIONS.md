# Operation: Doctor — Decisions Log

## Purpose
This file stores official project decisions so they do not get lost in chat.

## Decision Record Format
```text
ID:
Date:
Decision:
Reason:
Impacted Files:
Status:
```

## DEC-001
Date: 2026-05-22
Decision: Project name is Operation: Doctor.
Reason: English, marketable, and aligned with the clinic simulation theme.
Impacted Files: All project documents.
Status: Active.

## DEC-002
Date: 2026-05-22
Decision: Minimum department structure is 6 departments.
Reason: Minimum complexity with clear routing for issue-based chatbot workflow.
Impacted Files: `02_DEPARTMENT_RULES.md`, `departments/*.md`, workflow.
Status: Active.

## DEC-003
Date: 2026-05-22
Decision: `00_DoctorSim_2_5D_Oyun_Evreni_Referans.md` is included as inspiration only.
Reason: Supports world-building and progression ideas; not canon.
Impacted Files: `docs/START_HERE.md`, `docs/PROJECT_BIBLE.md`, `docs/HANDOFF.md`.
Status: Active.

## DEC-004
Date: 2026-05-22
Decision: Department Orchestrator issue automation will be used.
Reason: Department bot responses and decisions stay traceable in GitHub.
Impacted Files: `.github/workflows/department-orchestrator.yml`, `departments/*.md`.
Status: Active.

## DEC-005
Date: 2026-05-24
Decision: Unity is the approved engine direction.
Reason: Officially frozen in Stage 11 planning and required for shell-first setup.
Impacted Files: `docs/ENGINE_DECISION.md`, `docs/STAGE_11_UNITY_SETUP_PLAN.md`, `docs/HANDOFF.md`.
Status: Active.

## DEC-006
Date: 2026-05-25
Decision: Stage 15 must run as controlled handoff with shell-first boundaries.
Reason: Prevent full production start and scope creep during Codex onboarding.
Impacted Files: `docs/STAGE_15_CONTROLLED_HANDOFF_CHECKLIST.md`, `docs/STAGE_15_FIRST_TASK_SCOPE.md`, `docs/HANDOFF.md`.
Status: Active.

## DEC-007
Date: 2026-05-25
Decision: WP-15-01 must pass 6 validation gates before wider tasks.
Reason: Enforces folder, data, UI, loop, scope guard, and handoff checks.
Impacted Files: `docs/STAGE_15_WP_15_01_GATE_REPORT.md`, `docs/STAGE_15_CONTROLLED_HANDOFF_CHECKLIST.md`.
Status: Active.

## DEC-008
Date: 2026-05-25
Decision: WP-15-02 data contract draft is the placeholder reference for first playable sample groups.
Reason: Stabilizes sample data shape without runtime implementation.
Impacted Files: `docs/STAGE_15_WP_15_02_DATA_CONTRACT_DRAFT.md`, `docs/STAGE_14_SAMPLE_DATA_SET.md`.
Status: Active.

## Next Notes
- New decisions should continue from `DEC-009`.
- Any post-freeze change that affects scope, boundary, or workflow must be recorded here.
