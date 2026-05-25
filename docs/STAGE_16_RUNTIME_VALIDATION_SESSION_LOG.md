# Operation: Doctor — Stage 16 Runtime Validation Session Log

## Last Updated
2026-05-25

## Purpose
Track every Unity validation run in a consistent, auditable format.

## Log Table
| Run ID | Request ID | Date | Run Owner | Reviewer | Scene | Outcome (PASS/PARTIAL/FAIL) | Report File | PR Link | Blockers | Next Action |
|---|---|---|---|---|---|---|---|---|---|---|
| RUN-002 | READY-REQ-TBD |  |  |  |  |  | `docs/STAGE_16_RUNTIME_VALIDATION_REPORT_002.md` |  |  |  |
| RUN-EXAMPLE-READY-COMM | EXAMPLE_READY-REQ-20260525-01 | NOT_EXECUTED_TEMPLATE | EXAMPLE_RunOwner_Name | EXAMPLE_Reviewer_Name | EXAMPLE_FirstPlayableScene | NOT_EXECUTED_TEMPLATE | N/A | N/A | Example only | Replace with real run data |

## Session Entry Completeness Guard
Before publishing or updating a real run row:
1. `Run ID`, `Request ID`, `Date`, `Run Owner`, `Reviewer`, and `Outcome` are non-empty.
2. `Report File`, `PR Link`, and `Next Action` are filled for executed runs.
3. Template placeholders (`EXAMPLE_`, `NOT_EXECUTED_TEMPLATE`, blank required cells) are removed from real rows.
4. If required cells remain incomplete, keep status BLOCKED and open a scoped follow-up issue.

## READY Communication Example (Not Executed)
This entry is a format example only and does not represent a completed Unity run.

- READY request comment reference: `<issue-or-pr-comment-link>`
- READY confirmation comment reference: `<issue-or-pr-comment-link>`
- Template source: `docs/STAGE_16_RUNTIME_VALIDATION_READY_REQUEST_TEMPLATE.md`
- Gate decision in this example: BLOCKED (until real mandatory checks are completed)

## Per-Run Notes Template
```text
Run ID:
Request ID:
Date/Time:
Unity Version:
Scene:
Owner:
Reviewer:

Checklist Group Results:
A (Scene Wiring):
B (Reference Integrity):
C (Flow Behavior):
D (Boundary Guard):

Console Summary:
Evidence Links:
Blockers:
Decision (PASS/PARTIAL/FAIL):
Next Action:
```

## Escalation Fields
- Critical blocker present: YES/NO
- Expansion blocked until resolved: YES/NO
- Follow-up issue ID:

## Decision Mapping Note
Use this mapping for consistent logging between run outcome and READY history decision:
- PASS -> `READY_APPROVED` (when READY checks and confirmations are complete)
- PARTIAL -> `READY_PENDING_RECHECK` (until scoped fixes and recheck complete)
- FAIL -> `READY_REJECTED` (gate remains BLOCKED)

Allowed READY decision values are only:
- `READY_APPROVED`
- `READY_REJECTED`
- `READY_PENDING_RECHECK`

If any other READY decision value is used, the READY record is invalid and gate must remain BLOCKED.
Reference:
- `docs/STAGE_16_RUNTIME_VALIDATION_GATE_STATUS.md`
- `docs/STAGE_16_RUNTIME_VALIDATION_READY_REQUEST_TEMPLATE.md`

## Publication Rule
For each completed run:
1. Publish or update corresponding report file.
2. Add PR link in log table.
3. Record final decision and next action owner.

## Publication Link Integrity Guard
Before closing a run row:
1. `Report File` must point to the final report path for that run (not a draft path).
2. `PR Link` must point to the PR that includes the corresponding report update.
3. Linked PR must be merged before run row can be treated as complete.
4. If report/PR linkage is missing or inconsistent, keep status BLOCKED and open a scoped follow-up issue.

## Run ID Uniqueness Guard
Before adding or finalizing a real run row:
1. `Run ID` must be unique across all real run rows in the table.
2. Template/example rows (`RUN-EXAMPLE-...`) must not be reused for real executions.
3. If a row is corrected, keep the same `Run ID`; do not duplicate with a second row for the same run.
4. If duplicate `Run ID` is detected, keep status BLOCKED and open a scoped follow-up issue.

## Boundary Reminder
Session log examples do not authorize runtime expansion or production rollout.
Canonical gate authority remains:
- `docs/STAGE_16_RUNTIME_VALIDATION_GATE_STATUS.md`
- `docs/STAGE_16_RUNTIME_VALIDATION_GATE_RECORD_002.md`
