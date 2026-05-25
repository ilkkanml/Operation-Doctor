# Operation: Doctor — Repo Structure Guide

## Purpose
This guide defines the planned repository structure for Unity setup.

## Unity Root Structure
```text
Assets/
Packages/
ProjectSettings/
Docs/
Tests/
Builds/
```

## Assets Structure
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
```

## Rules
- Keep code, data, scenes, art, and documentation separated.
- Do not mix prototype experiments with stable folders.
- Do not add production assets before prototype scope is approved.
- Keep data readable and versionable.

## Branch Direction
- Main branch stores approved docs and stable setup.
- Feature branches should be used for future implementation work.
- No production implementation starts before Stage 11 freeze.

## Next Step
Use this structure when the Unity project shell is created.
