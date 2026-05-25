# Operation: Doctor — Stage 16 Runtime Validation Checklist

## Purpose
Provide a small pass/fail checklist to validate current placeholder runtime wiring.

## Validation Scope
- Placeholder-only runtime scripts
- Scene/reference wiring expectations
- Smoke-driver behavior checks

## A. Scene Wiring Checks
- [ ] `FirstPlayableBootstrap` is attached in test scene.
- [ ] `FirstPlayableUIPanelSkeleton` is attached in test scene.
- [ ] `PlaceholderDataLoader` is attached in test scene.
- [ ] `FirstPlayableFlowCoordinator` is attached and references bootstrap/ui/data components.
- [ ] `FirstPlayableFlowSmokeDriver` is attached and references coordinator.

## B. Reference Integrity Checks
- [ ] UI panel references (queue/profile/action/result/reward) are assigned in inspector.
- [ ] Data loader manifest reference is assigned or intentionally empty with note.
- [ ] Missing-reference warnings are reviewed and documented.

## C. Flow Behavior Checks
- [ ] Initial state resolves to queue-visible boundary state.
- [ ] Flow can step through placeholder states without exceptions.
- [ ] Smoke driver auto-step works when enabled.
- [ ] Manual `StepOnce` works when auto-step is disabled.

## D. Boundary Guard Checks
- [ ] No advanced systems are introduced.
- [ ] No production-only content is required for validation.
- [ ] All touched runtime files remain under approved placeholder paths.

## Pass / Fail Rule
- PASS: all required checks complete with no critical exceptions.
- FAIL: any missing critical reference or state-step exception.

## Validation Report Template
Use this for each run:

```text
Date:
Validator:
Scene:
Check Result: PASS / FAIL
Failed Items:
Notes:
Next Action:
```

## Fail Action
If FAIL:
1. Stop broader runtime expansion.
2. Open a small scoped fix issue.
3. Re-run checklist before continuing.
