# Operation: Doctor — Engine Decision

## Decision
Unity is approved as the technical direction for Operation: Doctor.

## Reason
Unity fits the 2.5D simulation target, supports fast iteration, has strong UI tooling, and is easier to adopt for a small project workflow.

## Boundaries
- Unity is the selected engine direction.
- Stage 11 remains planning and setup oriented.
- No full prototype is included in Stage 11.
- No large gameplay implementation begins before Stage 11 freeze.

## Technical Direction
- Use a modular Unity project structure.
- Keep data in readable JSON where possible.
- Prepare first playable boundaries before implementation.
- Use GitHub for issue tracking and milestone control.
- Add build/test workflow planning before production work.

## Risks
- Unity learning curve may slow early setup.
- Poor folder structure can create long-term project debt.
- Data schemas must be stable before large content entry.
- CI/build workflow may require later license and runner setup.

## Next Step
Prepare Stage 11 setup docs and repo structure plan before any prototype work.
