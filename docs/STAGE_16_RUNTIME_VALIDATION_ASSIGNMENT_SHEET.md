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

## Role Separation Guard
Before READY transition:
1. `Run Owner` and `Report Approver` must be different people.
2. `Backup Reviewer` must not duplicate `Run Owner` in normal operation.
3. If temporary overlap is unavoidable, document reason and keep status BLOCKED until explicit approval.
4. Unresolved role overlap requires a scoped follow-up issue before runtime progression.

## Schedule Ordering Guard
Before READY transition:
1. `Target Report Publish Date` must be the same day as or later than the date portion of `Target Run Date`.
2. If `Target Run Date` changes, `Target Report Publish Date` and linked run-card schedule must be updated in the same cycle.
3. `Target Run Date` must include explicit local time, and `Target Report Publish Date` must use `YYYY-MM-DD` format.
4. If schedule ordering or format is inconsistent, keep status BLOCKED and open a scoped follow-up issue.

## Publish Date Trace Guard
Before READY transition:
1. `Target Report Publish Date` must be consistent with planned publish date references in run card and session log planning notes.
2. If publish date changes in assignment sheet, corresponding publish-date references must be updated in the same update cycle.
3. Publish-date references must use `YYYY-MM-DD` format across related docs.
4. If publish-date trace is missing or inconsistent, keep status BLOCKED and open a scoped follow-up issue.

## Request ID Date Alignment Guard
Before READY transition:
1. The `YYYYMMDD` segment in `Request ID` must match the date portion of `Target Run Date`.
2. If `Request ID` date segment and `Target Run Date` differ, regenerate/realign Request ID and update linked docs in the same cycle.
3. Date alignment updates must also be reflected in READY request comment and gate history row references.
4. If date alignment remains inconsistent, keep status BLOCKED and open a scoped follow-up issue.

## Assignment-to-Run Card Sync Guard
Before READY transition:
1. `Request ID`, `Run Owner`, `Backup Reviewer`, and `Target Run Date` values must match the run card for the same run.
2. If one of these fields changes in assignment sheet, the corresponding run card field must be updated in the same update cycle.
3. Any documented temporary mismatch must include explicit reason and owner in notes, with gate status remaining BLOCKED.
4. If cross-document sync is missing or inconsistent, stop transition and open a scoped follow-up issue.

## Report Approver Confirmation Guard
Before READY transition:
1. `Report Approver` confirmation must be recorded in a traceable location (issue comment, PR comment, or documented note).
2. Confirmation must reference the same `Request ID` and planned run/publish dates.
3. If approver changes, prior confirmation is invalid and a new confirmation is required in the same cycle.
4. Missing or stale approver confirmation keeps status BLOCKED and requires a scoped follow-up issue.

## Backup Reviewer Confirmation Guard
Before READY transition:
1. `Backup Reviewer` confirmation must be recorded in a traceable location (issue comment, PR comment, or documented note).
2. Confirmation must reference the same `Request ID` and planned run date.
3. If backup reviewer changes, prior confirmation is invalid and a new confirmation is required in the same cycle.
4. Missing or stale backup-reviewer confirmation keeps status BLOCKED and requires a scoped follow-up issue.

## Confirmation Timestamp Guard
Before READY transition:
1. Role confirmations (`Report Approver`, `Backup Reviewer`) must include timestamp in local `YYYY-MM-DD HH:MM` format.
2. Confirmation timestamp must be on or before `Target Run Date` and on or after assignment update date.
3. If role confirmation is updated, timestamp must be refreshed in the same update cycle.
4. Missing or stale confirmation timestamps keep status BLOCKED and require a scoped follow-up issue.

## Confirmation Reference Integrity Guard
Before READY transition:
1. Confirmation references must point to accessible issue/PR comments or documented notes in this repository context.
2. Referenced confirmation text must include the same `Request ID` as assignment fields.
3. If reference target is edited or deleted, add a fresh confirmation reference in the same update cycle.
4. Broken/mismatched confirmation references keep status BLOCKED and require a scoped follow-up issue.

## Confirmation Freshness Window Guard
Before READY transition:
1. Role confirmations should be refreshed if they are older than 7 calendar days relative to `Target Run Date`.
2. If `Target Run Date` shifts by more than 1 day, request fresh confirmations in the same update cycle.
3. Fresh confirmations must preserve the same `Request ID` and updated schedule references.
4. Stale confirmations without refresh keep status BLOCKED and require a scoped follow-up issue.

## Confirmation Scope-Change Guard
Before READY transition:
1. If assignment scope changes materially (owner role, run date, or publish date), prior confirmations become stale.
2. Scope changes require fresh confirmations from affected roles in the same update cycle.
3. Refreshed confirmations must reference updated scope and the same `Request ID`.
4. Unrefreshed confirmations after scope change keep status BLOCKED and require a scoped follow-up issue.

## Assignment Completion Trace Guard
Before READY transition:
1. Assignment completion status must reference where confirmations and schedule checks were validated.
2. Completion trace must include `Request ID`, validator identity, and validation timestamp.
3. If any completion trace element is missing, assignment cannot be marked READY.
4. Missing/ambiguous completion trace keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Change-Log Guard
Before READY transition:
1. Changes to assignment-critical fields (`Request ID`, owners, run/publish dates) must be logged with reason.
2. Change log must include who changed the field and when (`YYYY-MM-DD HH:MM` local).
3. If change affects confirmations, corresponding confirmation-refresh action must be referenced in the same log entry.
4. Missing change-log trace keeps status BLOCKED and requires a scoped follow-up issue.

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
