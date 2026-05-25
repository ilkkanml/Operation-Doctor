# Operation: Doctor - Stage 16 Runtime Validation Assignment Sheet

## Purpose
Assign clear ownership for Unity validation execution and Report 002 publication.

## Assignment Fields
- Run Owner:
- Backup Reviewer:
- Report Approver:
- Target Run Date:
- Target Report Publish Date:

## Filled Example Block (Template Only)
Use this block as format guidance only.
Replace every `EXAMPLE_` value before any READY request.

- Run Owner: EXAMPLE_RunOwner_Name
- Backup Reviewer: EXAMPLE_BackupReviewer_Name
- Report Approver: EXAMPLE_ReportApprover_Name
- Target Run Date: EXAMPLE_2026-05-26 10:30 (local time)
- Target Report Publish Date: EXAMPLE_2026-05-26

Validation note:
- If any `EXAMPLE_` value remains, gate must stay BLOCKED.

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
