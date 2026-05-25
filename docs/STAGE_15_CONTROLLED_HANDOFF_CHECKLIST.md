# Operation: Doctor — Stage 15 Controlled Handoff Checklist

## Purpose
This checklist controls the first Codex task after Stage 14 freeze.

## Stage 15 Boundary
Stage 15 allows controlled shell and first-playable preparation only.

Allowed:
- Unity shell verification
- First playable boundary mapping
- Docs-only clarification work

Not allowed:
- Full production start
- Scope expansion
- Gameplay feature implementation outside shell
- Final art/audio production
- Store/release preparation

## Entry Gate
- Stage 14 freeze is approved in `docs/MILESTONE_FREEZE.md`.
- Required Stage 11-14 planning files exist.
- Shell folders exist under `Assets/` and `BuildScripts/`.

## First Task Validation Gates
1. Folder Structure Check
- Confirm `Assets/Scenes`, `Assets/Scripts/Placeholder`, `Assets/Data/PlaceholderData`, `Assets/Prefabs/Shell`, `Assets/UI`, and `BuildScripts`.

2. Sample Data Source Check
- Use only `docs/STAGE_14_SAMPLE_DATA_SET.md` as planning source.

3. UI Boundary Check
- Keep only queue/profile/action/result/reward planning areas.

4. Minimum Loop Check
- Preserve `queue -> profile -> action -> result -> decision -> reward`.

5. Scope Guard Check
- Reject any request that introduces advanced systems, full catalogs, or production pipelines.

6. Handoff Check
- Record Stage 15 decisions in docs before opening wider implementation tasks.

## Exit Criteria
Stage 15 first task is complete only if:
- all six gates pass,
- no gameplay production code is introduced,
- scope remains inside Unity shell and first playable planning.
