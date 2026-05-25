# Operation: Doctor - Stage 16 Runtime Validation READY Request Template

## Purpose
Standardize READY request communication in issue/PR threads before Unity validation execution.

## Boundary
- Docs-only communication template.
- No runtime code or production authorization.

## Canonical Gate Authority
READY decision authority remains:
1. `docs/STAGE_16_RUNTIME_VALIDATION_GATE_STATUS.md`
2. `docs/STAGE_16_RUNTIME_VALIDATION_GATE_RECORD_002.md`

If comments conflict with these records, gate records win.

## Template A - READY Request (Run Owner)
Copy/paste and replace all placeholders:

```text
READY request: all field-fill protocol checks passed.

Run Owner: <name>
Timestamp: <YYYY-MM-DD HH:MM local>

Checklist confirmation:
- Assignment sheet five fields filled: YES
- Run card metadata fields filled: YES
- Owner/date consistency verified: YES
- Run card pre-run checklist completed: YES
- Boundary-breaking pending change: NO

Evidence links:
- Assignment sheet: <link>
- Run card: <link>
- Gate status board: <link>
- Gate record 002: <link>

Request:
Please review and provide READY confirmation if all checks are valid.
```

## Template B - READY Confirmation (Report Approver)
Copy/paste and replace all placeholders:

```text
READY confirmation: validated.

Report Approver: <name>
Timestamp: <YYYY-MM-DD HH:MM local>

Validation:
- READY request evidence links reviewed: YES
- Assignment/run-card consistency confirmed: YES
- Boundary guard maintained: YES

Decision:
- Gate transition authorization: READY_APPROVED

Note:
This approval authorizes validation execution only, not production expansion.
```

## Template C - READY Rejection (If Any Check Fails)
Copy/paste and replace all placeholders:

```text
READY rejected: mandatory checks are incomplete.

Reviewer: <name>
Timestamp: <YYYY-MM-DD HH:MM local>

Missing items:
1. <item>
2. <item>

Required action:
Complete missing items and re-submit READY request with updated evidence links.

Gate remains BLOCKED.
```

## Usage Rule
- All placeholders must be replaced before posting.
- If any placeholder remains, the comment is invalid for gate decision.
