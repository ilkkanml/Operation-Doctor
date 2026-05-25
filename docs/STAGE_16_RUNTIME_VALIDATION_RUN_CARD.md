# Operation: Doctor — Stage 16 Runtime Validation Run Card

## Purpose
Coordinate one Unity validation run and produce Report 002 consistently.

## Session Metadata
- Run Owner:
- Backup Reviewer:
- Planned Date:
- Unity Version:
- Scene Name:

## Pre-Run Checklist
- [ ] `docs/STAGE_16_RUNTIME_VALIDATION_CHECKLIST.md` opened
- [ ] `docs/STAGE_16_RUNTIME_VALIDATION_EXECUTION_GUIDE.md` opened
- [ ] `docs/STAGE_16_RUNTIME_VALIDATION_PACKET.md` opened
- [ ] `docs/STAGE_16_RUNTIME_VALIDATION_REPORT_002_DRAFT.md` copied for fill-in
- [ ] Placeholder scripts present in project

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
