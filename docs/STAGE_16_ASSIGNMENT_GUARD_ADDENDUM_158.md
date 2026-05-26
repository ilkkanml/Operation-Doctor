# Stage 16 Assignment Guard Addendum 158

## Purpose
Add one controlled governance guard for Stage 16 assignment escalation checkpoint-evidence alignment within first-playable preparation boundaries.

## Assignment Escalation Threshold-Response Evidence-Checkpoint Parity Guard
Before READY transition:
1. For the same `Request ID` (reopen threshold `3`+), each active threshold-response checkpoint must reference a matching evidence set that supports checkpoint status and next action.
2. If checkpoint status changes, linked evidence references must be refreshed in the same update cycle to preserve parity.
3. Parity trace must include owner identity, local timestamp, checkpoint identifier, and canonical evidence link.
4. Missing or inconsistent threshold-response evidence-checkpoint parity keeps status BLOCKED and requires a scoped follow-up issue.

## Boundary Reminder
- No production start.
- No scope expansion.
- Stay within Unity shell / first-playable preparation guardrails.