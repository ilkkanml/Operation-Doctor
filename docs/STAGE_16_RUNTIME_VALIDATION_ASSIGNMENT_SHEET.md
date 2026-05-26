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

## Assignment Change-Log Timestamp Order Guard
Before READY transition:
1. Assignment change-log timestamps for the same `Request ID` must be non-decreasing in `YYYY-MM-DD HH:MM` local format.
2. If a new entry timestamp is earlier than a prior entry for the same `Request ID`, the entry is invalid until corrected.
3. Timestamp-order corrections must reference superseded entries instead of silently overwriting trace history.
4. Unresolved timestamp-order mismatch keeps status BLOCKED and requires a scoped follow-up issue.

## Run-Date Timezone Label Guard
Before READY transition:
1. `Target Run Date` must include explicit local timezone label or offset (for example `America/New_York` or `UTC-04:00`) in addition to date/time.
2. The same timezone label or offset must be used consistently across assignment sheet, run card, and READY request comment for the same run.
3. If run-date timezone context changes, linked schedule references and confirmations must be refreshed in the same update cycle.
4. Missing or inconsistent timezone labeling keeps status BLOCKED and requires a scoped follow-up issue.

## Owner Availability Window Guard
Before READY transition:
1. `Run Owner` and `Backup Reviewer` must confirm availability window covering the planned `Target Run Date` slot.
2. Availability confirmation must include local date/time range and timezone context.
3. If `Target Run Date` changes outside confirmed availability window, availability confirmation must be refreshed in the same update cycle.
4. Missing or stale availability-window confirmation keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Evidence-Link Completeness Guard
Before READY transition:
1. Assignment record must reference current run card path and planned report path for the same `Request ID`.
2. If confirmations are captured in issue/PR comments, assignment trace must include canonical links to those comments.
3. When referenced artifacts or comment locations change, links must be updated in the same update cycle.
4. Missing, stale, or broken evidence links keep status BLOCKED and require a scoped follow-up issue.

## Assignment Request-ID Uniqueness Guard
Before READY transition:
1. `Request ID` must be unique for each Stage 16 validation run and must not be reused.
2. READY request comment, run card, and assignment sheet must reference only one active `Request ID` for the same run.
3. If duplicate or conflicting `Request ID` usage is found, generate a new `Request ID` and propagate updates in the same cycle.
4. Unresolved `Request ID` duplication keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Placeholder-Regression Guard
Before READY transition:
1. After active fields are filled, placeholder markers (`EXAMPLE_`, `TBD`, `TODO`) must not reappear in assignment-critical fields.
2. Related run card and READY request traces for the same `Request ID` must also be free of placeholder markers.
3. Placeholder cleanup or regression fixes must be logged in assignment change-log with updater identity and local timestamp.
4. Any placeholder regression keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Gate-History Backlink Guard
Before READY transition:
1. Assignment trace for each `Request ID` must reference the matching gate-history row identifier/location.
2. The referenced gate-history row must include a backlink to the same assignment record or issue/PR context.
3. If gate-history row is moved or regenerated, assignment and gate-history backlinks must be updated in the same cycle.
4. Missing or one-way linkage keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Escalation Response Window Guard
Before READY transition:
1. Assignment-related BLOCKED escalations must receive an initial owner or approver response within 24 hours of escalation timestamp.
2. Response trace must include responder identity, local timestamp, and explicit next action.
3. If response window is exceeded, assignment remains BLOCKED until exception reason and recovery plan are logged.
4. Missing or late escalation-response trace keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Run-Slot Conflict Guard
Before READY transition:
1. Planned `Target Run Date` slot for a `Request ID` must not conflict with another active validation run owned by the same required roles.
2. If a slot conflict exists, assignment must document conflict resolution (reschedule or role reassignment) before READY.
3. Conflict resolution updates must be reflected in assignment sheet, run card, and READY request trace in the same cycle.
4. Unresolved run-slot conflict keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Blocker Aging Guard
Before READY transition:
1. Any assignment blocker linked to the same `Request ID` older than 48 hours must include a refreshed status update.
2. Refreshed update must include blocker owner, local timestamp, and explicit next unblock action.
3. If there is no progress in the last 48 hours, escalation note must reference responsible owner/approver handoff.
4. Missing blocker-aging update keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Reference Snapshot Guard
Before READY transition:
1. READY trace must include snapshot identifiers (for example commit SHA or revision reference) for assignment sheet and run card linked to the same `Request ID`.
2. If either referenced artifact changes after snapshot capture, READY must be revalidated with refreshed snapshot identifiers.
3. Snapshot identifiers must be traceable from gate-history row and READY request comment for the same run.
4. Missing or stale snapshot references keep status BLOCKED and require a scoped follow-up issue.

## Assignment Publish-Date Freeze Window Guard
Before READY transition:
1. After READY preparation starts for a `Request ID`, `Target Report Publish Date` changes must be explicitly justified and approved before transition.
2. Publish-date change justification must include requester, approver, local timestamp, and updated downstream impact note.
3. Related schedule traces (assignment sheet, run card, READY request comment) must be synchronized in the same update cycle.
4. Missing freeze-window approval or unsynced publish-date updates keep status BLOCKED and require a scoped follow-up issue.

## Assignment Reviewer-Handoff Acknowledgment Guard
Before READY transition:
1. When assignment responsibility is handed off (owner/reviewer/approver role), both outgoing and incoming owners must leave explicit acknowledgment trace.
2. Handoff trace must include `Request ID`, role scope, local timestamp, and effective handoff moment.
3. Assignment sheet, run card, and READY request trace must reflect the same handoff outcome in the same update cycle.
4. Missing or one-sided handoff acknowledgment keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment READY-Request Consistency Stamp Guard
Before READY transition:
1. READY request trace must include a consistency stamp summarizing `Request ID`, role owners, `Target Run Date`, and `Target Report Publish Date` from assignment sheet.
2. If any stamped field changes after stamp creation, the stamp is invalid and must be regenerated in the same update cycle.
3. The same consistency stamp reference must be visible from assignment sheet note, run card note, and READY request comment.
4. Missing or stale consistency stamp keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Pre-Run Reminder Acknowledgment Guard
Before READY transition:
1. Assigned roles (`Run Owner`, `Backup Reviewer`, `Report Approver`) must acknowledge pre-run reminder before `Target Run Date`.
2. Reminder acknowledgment must include `Request ID`, role name, and local acknowledgment timestamp.
3. If run date changes materially, pre-run reminder acknowledgments must be refreshed in the same update cycle.
4. Missing or stale pre-run reminder acknowledgment keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Late-Status Escalation Owner-Ack Guard
Before READY transition:
1. If assignment status remains `BLOCKED` within 24 hours of `Target Run Date`, `Run Owner` must post escalation acknowledgment.
2. Escalation acknowledgment must include `Request ID`, blocker summary, and immediate next action with local timestamp.
3. If `Run Owner` is unavailable, `Backup Reviewer` must post temporary acknowledgment and notify `Report Approver` in the same cycle.
4. Missing late-status escalation acknowledgment keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Escalation Follow-Up Deadline Guard
Before READY transition:
1. Each assignment escalation for the same `Request ID` must define a concrete follow-up deadline in local `YYYY-MM-DD HH:MM` format.
2. Follow-up deadline trace must name responsible owner (`Run Owner` or delegated role) and expected unblock checkpoint.
3. If follow-up deadline passes without update, escalation must be re-acknowledged by owner and re-notified to `Report Approver` in the same cycle.
4. Missing or expired follow-up deadline trace keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Escalation Resolution Verification Guard
Before READY transition:
1. When an escalated assignment blocker is marked resolved, `Run Owner` must record explicit resolution verification.
2. Resolution verification trace must include `Request ID`, resolved blocker reference, evidence link, and local timestamp.
3. `Backup Reviewer` must confirm resolution validity or reopen escalation in the same cycle if evidence is insufficient.
4. Missing or unverified escalation resolution trace keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Escalation Closure Approval Guard
Before READY transition:
1. After escalation resolution is verified, `Report Approver` must record explicit closure approval for the same `Request ID`.
2. Closure approval trace must include approved resolution reference, approver identity, and local timestamp.
3. If closure approval is deferred, assignment must remain `BLOCKED` with a documented reason and next approval checkpoint.
4. Missing or deferred-without-checkpoint closure approval keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Escalation Trace Completeness Guard
Before READY transition:
1. Escalation trace for the same `Request ID` must include initiation, acknowledgment, follow-up, resolution, and closure approval references.
2. Each trace element must include owner identity and local timestamp in `YYYY-MM-DD HH:MM` format.
3. If any escalation trace element is missing, assignment must remain `BLOCKED` until the missing reference is added in the same cycle.
4. Incomplete escalation trace history keeps status BLOCKED and requires a scoped follow-up issue.

## Assignment Escalation Trace Link-Validity Guard
Before READY transition:
1. Each escalation trace reference for the same `Request ID` must point to a reachable repository artifact/comment link and must not be placeholder text.
2. Linked evidence must contain matching `Request ID` and relevant escalation-phase context.
3. If a referenced link is moved, edited, or deleted, assignment trace must be updated with replacement link in the same cycle.
4. Any broken or mismatched escalation trace link keeps status BLOCKED and requires a scoped follow-up issue.

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
