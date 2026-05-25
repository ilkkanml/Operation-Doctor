# Operation: Doctor — Stage 16 Runtime Validation Report 002 (Draft)

## Status
Pending Unity execution run.

## Metadata
- Request ID:
- Date:
- Validator:
- Scene:
- Unity Version:

## Trace Consistency
- Request ID format: `READY-REQ-YYYYMMDD-XX`
- Request ID must match assignment sheet, run card, READY request comment, and READY history row in gate status board.

## Checklist Group Results
- A. Scene Wiring Checks: NOT_RUN
- B. Reference Integrity Checks: NOT_RUN
- C. Flow Behavior Checks: NOT_RUN
- D. Boundary Guard Checks: NOT_RUN

## A. Scene Wiring Checks
- A1 Bootstrap attached: NOT_RUN
- A2 UI skeleton attached: NOT_RUN
- A3 Data loader attached: NOT_RUN
- A4 Coordinator references set: NOT_RUN
- A5 Smoke driver references set: NOT_RUN

## B. Reference Integrity Checks
- B1 UI panel refs assigned: NOT_RUN
- B2 Manifest/sample refs assigned: NOT_RUN
- B3 Missing-reference warnings reviewed: NOT_RUN

## C. Flow Behavior Checks
- C1 Initial queue state works: NOT_RUN
- C2 Auto-step progression works: NOT_RUN
- C3 Manual step works: NOT_RUN
- C4 No critical exceptions: NOT_RUN

## D. Boundary Guard Checks
- D1 Only approved placeholder paths touched: NOT_RUN
- D2 No advanced systems involved: NOT_RUN
- D3 No production-only dependency required: NOT_RUN

## Evidence Section
- Console Summary:
- Screenshots:
- Notes:

## Failed Items
- (to be filled)

## Blockers
- (to be filled)

## Decision Justification Guard
Before finalizing decision:
1. Select exactly one decision value: PASS, PARTIAL, or FAIL.
2. PASS requires evidence section completion and no unresolved critical blockers.
3. PARTIAL/FAIL requires at least one explicit failed item or blocker entry.
4. If decision and evidence/blocker state conflict, keep draft pending and open a scoped follow-up issue.

## Decision
- PASS / PARTIAL / FAIL

## Next Action
- If PASS: proceed to next small scoped runtime task.
- If PARTIAL/FAIL: open scoped fix issue and re-run validation.

## Next Action Ownership Guard
Before closing report:
1. `Next Action` must be filled for all decision states.
2. If decision is PASS, `Next Action` must reference the next scoped runtime task or issue ID.
3. If decision is PARTIAL/FAIL, `Next Action` must include fix owner, target date (`YYYY-MM-DD`), and follow-up issue ID.
4. If owner/date/issue trace is incomplete, keep draft pending and block gate progression.

## READY Mapping Consistency Guard
Before publication:
1. Apply only this mapping: PASS -> `READY_APPROVED`, PARTIAL -> `READY_PENDING_RECHECK`, FAIL -> `READY_REJECTED`.
2. The mapped READY decision must appear in gate status history for the same `Request ID`.
3. Any non-allowed READY value invalidates publication and gate remains BLOCKED.
4. If mapping update is missing or inconsistent, keep draft pending and open a scoped follow-up issue.

## Metadata Completeness Guard
Before publication:
1. `Request ID`, `Date`, `Validator`, `Scene`, and `Unity Version` must be non-empty.
2. `Date` must use `YYYY-MM-DD` format.
3. `Request ID` date segment (`YYYYMMDD`) must match `Date` for the same run.
4. If metadata is incomplete or inconsistent, keep draft pending and block gate progression.

## Evidence Trace Guard
Before publication:
1. PASS requires non-empty `Console Summary` and at least one screenshot or equivalent evidence reference.
2. PARTIAL/FAIL requires evidence references for every listed failed item or blocker.
3. Evidence entries must be stable references (repository path, issue/PR link, or archived artifact link).
4. If evidence trace is missing or ambiguous, keep draft pending and open a scoped follow-up issue.

## Placeholder Clearance Guard
Before publication:
1. Replace `(to be filled)` placeholders in `Failed Items` and `Blockers` with explicit content.
2. If there is no item, write `None` explicitly instead of leaving template text.
3. Published report must not contain unresolved template markers (`TBD`, `EXAMPLE_`, `<...>`).
4. If any placeholder remains, keep draft pending and block gate progression.

## Boundary Result Recording Guard
Before publication:
1. Record boundary outcomes using explicit lines for `full production start`, `scope expansion`, and `Unity shell boundary break`.
2. Each boundary line must use fixed binary wording: `yes` or `no`.
3. Ordering of boundary lines must remain: full production start -> scope expansion -> Unity shell boundary break.
4. If boundary lines are missing, non-binary, or out of order, keep draft pending and block gate progression.
