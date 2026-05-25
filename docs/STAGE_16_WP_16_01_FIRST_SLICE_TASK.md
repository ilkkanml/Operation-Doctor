# Operation: Doctor — Stage 16 WP-16-01 First Slice Task

## Purpose
Define the first technical slice as a docs-first reviewed task before runtime implementation.

## Task ID
WP-16-01

## Slice Goal
Validate that the Unity shell can host the first playable placeholder flow boundaries without expanding scope.

## In Scope
- Verify placeholder scene location usage (`Assets/Scenes`).
- Verify placeholder data location usage (`Assets/Data/PlaceholderData`).
- Define UI boundary mapping notes for:
  - queue area
  - profile card
  - action area
  - result feedback
  - reward feedback
- Define pass/fail checks for this slice.

## Out of Scope
- Runtime gameplay logic implementation.
- New advanced systems (staff, room, follow-up, economy).
- Full content catalog integration.
- Production art/audio/release workflow.

## Deliverables
- This task definition file.
- A follow-up implementation issue created only after docs review passes.

## Review Gate Mapping
Gate A — Boundary Integrity
- Must remain first-slice only.

Gate B — Deliverable Type
- Docs-first only in this task.

Gate C — First Playable Guard
- Must preserve queue/profile/action/result/reward boundary.

Gate D — Data Guard
- Must use sample/placeholder data references only.

Gate E — Traceability
- Must link issue, PR, and handoff status update when needed.

## Pass Criteria
- Scope is exact and minimal.
- No production-start language or implementation action exists.
- Follow-up work can be split into small reviewable tasks.

## Fail Criteria
- Any request adds runtime implementation in this task.
- Any request expands into advanced systems.
- Any request bypasses shell/placeholder boundaries.

## Stop Rule
If fail criteria is triggered, stop immediately, split request, and return to boundary docs for correction.
