# Operation: Doctor — Stage 15 Review Gate Checklist

## Purpose
Apply this checklist before merging any Stage 15 task PR.

## Gate A — Boundary Integrity
- [ ] Task stays inside Stage 15 controlled scope.
- [ ] No full production kickoff is included.
- [ ] No Unity shell boundary violations exist.

## Gate B — Deliverable Type
- [ ] Deliverables are docs-only or shell-safe placeholders.
- [ ] No gameplay/runtime production code was introduced.
- [ ] No production assets or release pipeline content was added.

## Gate C — First Playable Guard
- [ ] Flow boundary remains `queue -> profile -> action -> result -> decision -> reward`.
- [ ] No advanced staff/room/follow-up/economy systems were introduced.

## Gate D — Data Guard
- [ ] Sample-data tasks use approved Stage 14/15 references only.
- [ ] No full catalog or balancing expansion is introduced.

## Gate E — Traceability
- [ ] Related issue and PR are linked.
- [ ] `docs/HANDOFF.md` and/or `docs/DECISIONS.md` are updated when needed.
- [ ] Decision impact is explicit and reversible.

## Merge Decision
- PASS: all gates checked.
- FAIL: any unchecked or boundary-breaking item.

## Fail Action
Do not merge. Split the oversized request into a new scoped task and return to Stage 15 boundary docs.
