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

### Step 1 - Fill Assignment Sheet (Owner First)
Document: `docs/STAGE_16_RUNTIME_VALIDATION_ASSIGNMENT_SHEET.md`

Fill in exact order:
1. Run Owner
2. Backup Reviewer
3. Report Approver
4. Target Run Date
5. Target Report Publish Date

Checkpoint:
- All five fields are non-empty.

### Step 2 - Mirror Run Metadata to Run Card
Document: `docs/STAGE_16_RUNTIME_VALIDATION_RUN_CARD.md`

Fill in exact order:
1. Run Owner (must match assignment sheet)
2. Backup Reviewer (must match assignment sheet)
3. Planned Date (must match target run date/time)
4. Unity Version
5. Scene Name

Checkpoint:
- Owner/date values are consistent across both docs.

### Step 3 - Complete Pre-Run Checklist
Document: `docs/STAGE_16_RUNTIME_VALIDATION_RUN_CARD.md`

Mark complete:
- Validation checklist opened
- Execution guide opened
- Validation packet opened
- Report 002 draft copied for fill
- Placeholder scripts present

Checkpoint:
- No pre-run item remains unchecked.

### Step 4 - Record READY Confirmation Inputs
Record in issue or PR thread:
1. Run Owner written confirmation with timestamp
2. Report Approver written confirmation with timestamp

Checkpoint:
- Both confirmations are present.

## Final Verification Before READY Request
All must be true:
- [ ] Assignment sheet five fields are filled
- [ ] Run card metadata fields are filled
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