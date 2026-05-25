# Operation: Doctor - Stage 16 Runtime Validation Run Card

## Last Updated
2026-05-25

## Purpose
Coordinate one Unity validation run and produce Report 002 consistently.

## Session Metadata
- Request ID:
- Run Owner:
- Backup Reviewer:
- Planned Date:
- Unity Version:
- Scene Name:

Request ID format:
- `READY-REQ-YYYYMMDD-XX`

## Filled Example Block (Template Only)
Use this block as format guidance only.
Replace every `EXAMPLE_` value before run kickoff.

- Request ID: EXAMPLE_READY-REQ-20260525-01
- Run Owner: EXAMPLE_RunOwner_Name
- Backup Reviewer: EXAMPLE_BackupReviewer_Name
- Planned Date: EXAMPLE_2026-05-26 10:30 (local time)
- Unity Version: EXAMPLE_Unity_6000.0.x
- Scene Name: EXAMPLE_FirstPlayableScene

Validation note:
- If any `EXAMPLE_` value remains, kickoff must stay BLOCKED.

## Pre-Run Checklist
- [ ] `docs/STAGE_16_RUNTIME_VALIDATION_CHECKLIST.md` opened
- [ ] `docs/STAGE_16_RUNTIME_VALIDATION_EXECUTION_GUIDE.md` opened
- [ ] `docs/STAGE_16_RUNTIME_VALIDATION_PACKET.md` opened
- [ ] `docs/STAGE_16_RUNTIME_VALIDATION_REPORT_002_DRAFT.md` copied for fill-in
- [ ] Placeholder scripts present in project
- [ ] Request ID matches READY request comment and gate history row

## Run Checklist
- [ ] Scene setup verified (A checks)
- [ ] Inspector references verified (B checks)
- [ ] Play-mode flow verified (C checks)
- [ ] Boundary guard verified (D checks)
- [ ] Console summary captured
- [ ] Evidence table completed

## Post-Run Checklist
- [ ] Report 002 draft filled with final PASS/FAIL/NOT_RUN values
- [ ] Failed items and blockers explicitly listed
- [ ] Decision set to PASS / PARTIAL / FAIL
- [ ] Next action and owner recorded

## Checklist Completion Guard
Before entering publish flow:
1. Every checklist item is either completed or explicitly marked NOT_RUN with reason.
2. Any unresolved critical checklist item blocks PASS decision.
3. Remaining gaps must appear in blockers and next-action fields.
4. If checklist state is ambiguous, stop and open a scoped follow-up issue.

## Post-Run Trace Sync Guard
Before entering publish flow:
1. `Request ID` must match across run card, report draft, and session log row for the same run.
2. Decision and next-action owner in run card must match the report draft values.
3. If decision is PARTIAL/FAIL, follow-up issue ID must be recorded in both run card and report draft.
4. Any trace mismatch keeps status BLOCKED and requires a scoped follow-up issue.

## Publish Flow
1. Save completed report as `docs/STAGE_16_RUNTIME_VALIDATION_REPORT_002.md`
2. Open a small docs-only PR with report file
3. Link evidence and validation decision in PR body
4. If PASS: open next small scoped runtime issue
5. If PARTIAL/FAIL: open scoped fix issue first

## Escalation Rules
- FAIL with critical reference errors: block runtime expansion.
- PARTIAL with non-critical gaps: allow only scoped fix tasks.
- Boundary break detected: stop immediately and return to docs-first correction.

## Notes
- This run card is coordination-only.
- It does not authorize production expansion by itself.
