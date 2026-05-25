# Operation: Doctor — Stage 16 Runtime Validation Packet

## Purpose
Single packet to execute and document the next Unity validation run.

## Trace Header
- Request ID:
- Request ID Format: `READY-REQ-YYYYMMDD-XX`
- Trace Rule: Request ID must match assignment sheet, run card, READY request comment, and gate history row.
- Not-Ready Rule: if Request ID is missing, invalid, or mismatched, keep gate/kickoff BLOCKED.

## Run Order
1. Fill Request ID in Trace Header.
2. Open `docs/STAGE_16_RUNTIME_VALIDATION_CHECKLIST.md`
3. Follow `docs/STAGE_16_RUNTIME_VALIDATION_EXECUTION_GUIDE.md`
4. Capture results into the evidence table below
5. Publish `REPORT_002` using the template in this packet

## Evidence Capture Table
| Item ID | Check | Result (PASS/FAIL/NOT_RUN) | Evidence | Notes |
|---|---|---|---|---|
| A1 | Bootstrap attached |  |  |  |
| A2 | UI skeleton attached |  |  |  |
| A3 | Data loader attached |  |  |  |
| A4 | Coordinator references set |  |  |  |
| A5 | Smoke driver references set |  |  |  |
| B1 | UI panel refs assigned |  |  |  |
| B2 | Manifest/sample refs assigned |  |  |  |
| C1 | Initial queue state works |  |  |  |
| C2 | Auto-step progression works |  |  |  |
| C3 | Manual step works |  |  |  |
| D1 | Boundary guard still intact |  |  |  |

## Report 002 Template
```text
Title: Stage 16 Runtime Validation Report 002
Request ID:
Date:
Validator:
Scene:

A. Scene Wiring Checks: PASS/FAIL/NOT_RUN
B. Reference Integrity Checks: PASS/FAIL/NOT_RUN
C. Flow Behavior Checks: PASS/FAIL/NOT_RUN
D. Boundary Guard Checks: PASS/FAIL/NOT_RUN

Failed Items:
Blockers:
Evidence Summary:
Next Action:
Decision: PASS / PARTIAL / FAIL
```

## Fail Escalation Rules
- If any critical reference is missing: mark FAIL, open a small scoped fix issue.
- If play-mode throws repeated exceptions: stop expansion and fix only failing slice.
- If boundary guard is broken: stop immediately and return to docs-first correction.

## Exit Rule
Do not start broader runtime expansion until Report 002 is published and reviewed.
