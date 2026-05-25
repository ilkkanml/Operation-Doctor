# Operation: Doctor - Stage 16 Runtime Validation Field Fill Protocol

## Purpose
Define one deterministic process to fill `ASSIGNMENT_SHEET` and `RUN_CARD` before any READY request.

## Boundary
- Docs-only operational protocol.
- No runtime code changes.
- No production rollout authorization.

## Canonical Gate Authority
Gate state authority is:
1. `docs/STAGE_16_RUNTIME_VALIDATION_GATE_STATUS.md`
2. `docs/STAGE_16_RUNTIME_VALIDATION_GATE_RECORD_002.md`

This protocol cannot override gate authority.

## Required Roles
- Run Owner
- Backup Reviewer
- Report Approver

If any role is unassigned, state stays BLOCKED.

## Step-by-Step Fill Order

### Step 1 - Fill Assignment Sheet (Request ID + Owner First)
Document: `docs/STAGE_16_RUNTIME_VALIDATION_ASSIGNMENT_SHEET.md`

Fill in exact order:
1. Request ID (must match `READY-REQ-YYYYMMDD-XX`)
2. Run Owner
3. Backup Reviewer
4. Report Approver
5. Target Run Date
6. Target Report Publish Date

Checkpoint:
- All six fields are non-empty.
- Request ID format is valid.

### Step 2 - Mirror Run Metadata to Run Card
Document: `docs/STAGE_16_RUNTIME_VALIDATION_RUN_CARD.md`

Fill in exact order:
1. Request ID (must match assignment sheet)
2. Run Owner (must match assignment sheet)
3. Backup Reviewer (must match assignment sheet)
4. Planned Date (must match target run date/time)
5. Unity Version
6. Scene Name

Checkpoint:
- Request ID values are consistent across assignment sheet and run card.
- Owner/date values are consistent across both docs.

### Step 3 - Complete Pre-Run Checklist
Document: `docs/STAGE_16_RUNTIME_VALIDATION_RUN_CARD.md`

Mark complete:
- Validation checklist opened
- Execution guide opened
- Validation packet opened
- Report 002 draft copied for fill
- Placeholder scripts present
- Request ID matches READY request comment and gate history row

Checkpoint:
- No pre-run item remains unchecked.

### Step 4 - Record READY Confirmation Inputs
Record in issue or PR thread:
1. Run Owner READY request comment with Request ID + timestamp
2. Report Approver confirmation (or rejection) with timestamp
3. READY history row updated with same Request ID and both comment links

Checkpoint:
- Both confirmations are present.
- Gate history row has matching Request ID and links.

## Final Verification Before READY Request
All must be true:
- [ ] Assignment sheet six fields are filled
- [ ] Run card metadata fields are filled
- [ ] Request ID format is valid (`READY-REQ-YYYYMMDD-XX`)
- [ ] Request ID is consistent across request comment, assignment sheet, run card, and gate history row
- [ ] Owner/date consistency is verified
- [ ] Run card pre-run checklist is fully checked
- [ ] Run Owner confirmation is recorded
- [ ] Report Approver confirmation is recorded
- [ ] No boundary-breaking runtime change is pending

If any checkbox is false, gate remains BLOCKED.

## READY Request Output Format
When all verifications pass, post one short note in issue/PR:
- "READY request: all field-fill protocol checks passed."
- Include links to assignment sheet, run card, and gate status board.

## Notes
This protocol prepares validation execution only. It does not authorize production-scale expansion.