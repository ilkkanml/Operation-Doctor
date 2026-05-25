# Operation: Doctor — Stage 16 WP-16-04 Runtime Task Split Map

## Purpose
Split the first runtime implementation wave into small, boundary-safe PR tasks.

## Dependency Order
1. T1 — Scene Placeholder Wiring
2. T2 — Placeholder Data Loader Hook
3. T3 — UI Boundary Panels Skeleton
4. T4 — First Flow State Transition Stub

No task may start before its previous dependency is merged.

## T1 — Scene Placeholder Wiring
### In Scope
- Minimal scene reference wiring in shell-safe path.

### Out of Scope
- Gameplay logic and advanced systems.

### Pass Criteria
- Scene placeholder is connected and reviewable in one PR.

### Stop Condition
- Any change outside allowed path boundary.

## T2 — Placeholder Data Loader Hook
### In Scope
- Minimal placeholder data loading hook for first-slice references.

### Out of Scope
- Full content catalogs and balancing.

### Pass Criteria
- Placeholder data can be referenced by first-slice components.

### Stop Condition
- Data schema expansion beyond approved sample groups.

## T3 — UI Boundary Panels Skeleton
### In Scope
- Skeleton-level panels for queue/profile/action/result/reward.

### Out of Scope
- Final art/animation polish and advanced UI systems.

### Pass Criteria
- All five boundary panels exist in minimal placeholder form.

### Stop Condition
- UI work introduces non-boundary systems.

## T4 — First Flow State Transition Stub
### In Scope
- Minimal non-production stub for boundary flow transitions.

### Out of Scope
- Full gameplay loop completion and advanced feature set.

### Pass Criteria
- Transition stub demonstrates controlled boundary progression only.

### Stop Condition
- Scope moves into full loop production implementation.

## Global Rules
- Each task must be one small PR.
- Each PR must use the runtime PR template.
- Any FAIL in review gate checklist blocks merge.
- On boundary breach: stop, split, and return to docs-first correction.
