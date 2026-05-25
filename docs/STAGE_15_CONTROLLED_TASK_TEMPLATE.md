# Operation: Doctor — Stage 15 Controlled Task Template

## Purpose
Use this template for every Stage 15 Codex task to prevent scope drift.

## Task ID
`WP-15-XX`

## Task Title
`<short task title>`

## Objective
`<single controlled objective>`

## Scope Reference
- `docs/STAGE_15_CONTROLLED_HANDOFF_CHECKLIST.md`
- `docs/STAGE_15_FIRST_TASK_SCOPE.md`
- `docs/HANDOFF.md`
- `docs/DECISIONS.md`

## In Scope
- `<docs-only or shell-safe action 1>`
- `<docs-only or shell-safe action 2>`

## Out of Scope
- full production start
- scope expansion outside first playable boundary
- gameplay/runtime coding beyond placeholder planning
- production art/audio/release workflow changes

## Inputs
- `<source doc 1>`
- `<source doc 2>`

## Deliverables
- `<docs file 1>`
- `<docs file 2 (optional)>`
- `<small PR link>`

## Validation Gates (Must Pass)
1. Folder/Shell boundary remains intact.
2. Data source stays within approved sample documents.
3. UI/loop boundary remains queue/profile/action/result/reward.
4. No advanced systems are introduced.
5. Handoff + decision trace is maintained.

## Stop Rule
If any requested change exceeds this template boundary, stop implementation and split that request into a new later-stage task.

## Exit Criteria
- All validation gates pass.
- Deliverables are docs-only or shell-safe.
- No runtime production systems are added.
