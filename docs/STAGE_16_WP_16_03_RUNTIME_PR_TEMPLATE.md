# Operation: Doctor — Stage 16 WP-16-03 Runtime PR Template

## Usage
Use this template for the first runtime implementation PR and follow it section by section.

## 1. Objective
- What single first-slice runtime behavior is implemented?

## 2. Scope
### In Scope
- List only first playable boundary items.

### Out of Scope
- Advanced systems (staff/room/follow-up/economy)
- Full production expansion
- Release/store workflow changes

## 3. Allowed File Boundary
Declare exact touched paths:
- `Assets/Scenes/`
- `Assets/Scripts/Placeholder/`
- `Assets/Data/PlaceholderData/`
- `Assets/UI/`

If any file is outside this list, explain why and request separate scoped approval.

## 4. Change Summary
- Short list of concrete runtime changes.
- Keep the list minimal and reviewable.

## 5. Review Gate Checklist
- [ ] Boundary Integrity PASS
- [ ] Deliverable Type PASS
- [ ] First Playable Guard PASS
- [ ] Data Guard PASS
- [ ] Traceability PASS

If any item is FAIL, do not merge.

## 6. Test / Validation Notes
- What was validated?
- What is not yet validated?
- What remains for next small task?

## 7. Rollback Plan
If boundary breach or unexpected behavior appears:
1. Revert or close the PR without merge.
2. Split work into smaller scoped tasks.
3. Return to docs-first correction task.

## 8. Decision Record
- Link related issue and PR.
- Note whether `HANDOFF` or `DECISIONS` update is required.

## Stop Rule
If this template cannot be completed without exceptions, stop and rescope before merge.
