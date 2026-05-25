# Operation: Doctor - Stage 16 Runtime Validation Assignment Sheet

## Last Updated
2026-05-25

## Purpose
Assign clear ownership for Unity validation execution and Report 002 publication.

## Assignment Fields
- Request ID:
- Run Owner:
- Backup Reviewer:
- Report Approver:
- Target Run Date:
- Target Report Publish Date:

Request ID format:
- `READY-REQ-YYYYMMDD-XX`

## Filled Example Block (Template Only)
Use this block as format guidance only.
Replace every `EXAMPLE_` value before any READY request.

- Request ID: EXAMPLE_READY-REQ-20260525-01
- Run Owner: EXAMPLE_RunOwner_Name
- Backup Reviewer: EXAMPLE_BackupReviewer_Name
- Report Approver: EXAMPLE_ReportApprover_Name
- Target Run Date: EXAMPLE_2026-05-26 10:30 (local time)
- Target Report Publish Date: EXAMPLE_2026-05-26

Validation note:
- If any `EXAMPLE_` value remains, gate must stay BLOCKED.
- Request ID must match READY request comment, run card, and gate history row.

## Assignment Completeness Guard
Before READY transition:
1. `Request ID`, `Run Owner`, `Backup Reviewer`, and `Report Approver` are non-empty and non-TBD.
2. `Target Run Date` and `Target Report Publish Date` are set and not template placeholders.
3. No `EXAMPLE_` values remain in active assignment fields.
4. If any field is incomplete, keep gate/kickoff status BLOCKED and open a scoped follow-up issue.

## Responsibilities
### Run Owner
- [ ] Prepare scene and references using run card
- [ ] Execute checklist groups A-D
- [ ] Collect console/evidence notes
- [ ] Fill `REPORT_002` draft

### Backup Reviewer
- [ ] Verify checklist completeness
- [ ] Confirm PASS/FAIL labels are justified
- [ ] Confirm boundary guard section accuracy

### Report Approver
- [ ] Approve final report decision (PASS/PARTIAL/FAIL)
- [ ] Confirm next action is clearly assigned

## Evidence Handoff Requirements
- Console output summary attached in report
- Screenshot/evidence references listed
- Failed items and blockers explicitly listed

## Report 002 Publish Requirement
1. Finalize file as `docs/STAGE_16_RUNTIME_VALIDATION_REPORT_002.md`
2. Open docs-only PR with report
3. Link run evidence and decision in PR body
4. If PARTIAL/FAIL, open scoped fix issue before any runtime expansion

## Escalation Rule
If no owner is assigned by target date, runtime expansion remains blocked.
