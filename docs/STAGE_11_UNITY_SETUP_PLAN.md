# Operation: Doctor — Stage 11 Unity Setup Plan

## Purpose
This document defines Stage 11 setup direction after Unity approval.

## Engine Direction
Unity is approved for Operation: Doctor.

## Stage 11 Boundary
Stage 11 is planning and setup only.

Included:
- Unity project structure planning
- Repository structure planning
- JSON data direction
- First playable boundary planning
- Build/test workflow planning

Excluded:
- Full gameplay implementation
- Full prototype
- Production asset creation
- Store/release preparation

## Recommended Unity Structure
```text
Assets/
  Scenes/
  Scripts/
    Core/
    UI/
    Systems/
  Prefabs/
  Art/
  Audio/
  Data/
Packages/
ProjectSettings/
Docs/
Tests/
Builds/
```

## Data Direction
Use JSON for early content data where possible.

Planned data groups:
- visitors.json
- conditions.json
- checks.json
- actions.json
- staff.json
- rooms.json

## First Playable Boundary
The first playable should remain small:
- One clinic scene
- Basic queue
- Basic profile card
- Basic action flow
- Result-ready state
- Simple reward trigger

## Build/Test Workflow Direction
- Prepare Unity project first.
- Add basic GitHub Actions planning later.
- Do not build full CI before project structure exists.
- Manual validation comes first.

## Risks
- Scope creep into full prototype.
- Unstable folder structure.
- Data schema changes after content grows.
- Unity setup complexity for non-coders.

## Next Step
Stage 11 should continue with repository structure preparation and first playable scope confirmation.
