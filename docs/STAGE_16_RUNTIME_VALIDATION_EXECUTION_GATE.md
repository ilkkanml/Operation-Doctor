# Operation: Doctor — Stage 16 Runtime Validation Execution Gate

## Purpose
Prevent Unity validation run from starting until mandatory operational conditions are satisfied.

## Gate Status
Default: BLOCKED

Status can change to READY only after all mandatory conditions are met.

## Mandatory Go Conditions
1. Run Owner assigned in assignment sheet.
2. Backup Reviewer assigned.
3. Planned run date/time set.
4. Target scene and Unity version set.
5. Run card pre-run checklist marked complete.
6. Validation packet and Report 002 draft prepared.

## Authority to Flip BLOCKED -> READY
- Primary: Run Owner
- Secondary: Report Approver

Both must confirm in writing (issue comment or PR note).

## No-Go Triggers
Keep status BLOCKED if:
- owner/reviewer fields are empty,
- run date/time is missing,
- unresolved blocker from previous run exists,
- boundary-breaking runtime changes are pending.

## Post-Run Requirement
After execution:
1. Finalize `docs/STAGE_16_RUNTIME_VALIDATION_REPORT_002.md`
2. Publish report with docs-only PR
3. Update session log with outcome and PR link
4. If result is FAIL/PARTIAL, create scoped fix issue before any expansion

## Decision Rule
- READY does not mean production go-live.
- READY only authorizes validation run execution.
