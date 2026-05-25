# Operation: Doctor — Stage 16 Runtime Validation Execution Guide

## Purpose
Convert current `NOT_RUN` validation items into concrete PASS/FAIL results in Unity editor.

## Prerequisites
- Unity project opens without compile errors.
- Placeholder scripts from PRs #73, #75, #77, #79, #81 are present.
- `docs/STAGE_16_RUNTIME_VALIDATION_CHECKLIST.md` is open during execution.

## 1. Scene Setup
1. Open the first playable test scene.
2. Ensure the following components exist in scene:
- `FirstPlayableBootstrap`
- `FirstPlayableUIPanelSkeleton`
- `PlaceholderDataLoader`
- `FirstPlayableFlowCoordinator`
- `FirstPlayableFlowSmokeDriver`

## 2. Inspector Wiring
1. Assign queue/profile/action/result/reward GameObject references to `FirstPlayableUIPanelSkeleton`.
2. Assign manifest and sample assets to `PlaceholderDataLoader` (or document intentional empty state).
3. Assign `bootstrap`, `uiSkeleton`, and `dataLoader` references in `FirstPlayableFlowCoordinator`.
4. Assign coordinator reference in `FirstPlayableFlowSmokeDriver`.

## 3. Play-Mode Validation
1. Enter Play mode.
2. Confirm no critical exceptions in Console.
3. Verify initial state is queue-visible.
4. With smoke driver auto-step enabled, observe state progression.
5. Disable auto-step and call manual `StepOnce` path.
6. Confirm UI panel activation changes follow placeholder state transitions.

## 4. Evidence Capture
Record the following:
- Scene name and test date.
- Console output summary (warnings/errors).
- Which checklist items PASS/FAIL.
- Any missing references found.
- Screenshot list (optional but recommended).

## 5. Reporting
1. Create next validation report file (`REPORT_002`) using the report template.
2. Mark each checklist group with PASS/FAIL.
3. If FAIL exists, open a small scoped fix issue and do not expand runtime scope.

## 6. Stop Rule
Stop validation expansion if:
- reference assignment cannot be stabilized,
- state stepping throws recurring exceptions,
- scope pressure introduces advanced systems.

Return to boundary-safe fix tasks only.
