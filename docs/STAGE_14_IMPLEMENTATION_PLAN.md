# Operation: Doctor — Stage 14 Implementation Planning

## Purpose
This document defines the Stage 14 implementation planning boundary.

## Boundary
Stage 14 plans the first playable implementation tasks.
It does not start full production.

Included:
- Implementation order
- Unity shell usage
- Sample data usage
- Minimal UI order
- Test gate order

Excluded:
- Full production
- Large content catalog
- Final art pass
- Full audio pass
- Store or release preparation

## Implementation Order
```text
1. Use existing Unity shell structure
2. Prepare sample data references
3. Define minimum UI areas
4. Define core loop states
5. Define result feedback state
6. Define reward feedback state
7. Run QA gate before any wider production
```

## Unity Shell Usage
Use existing shell folders only:

```text
Assets/Scenes/
Assets/Scripts/Placeholder/
Assets/Data/PlaceholderData/
Assets/Prefabs/Shell/
Assets/UI/
BuildScripts/
```

No gameplay expansion should bypass the shell boundary.

## Sample Data Usage
Use the Stage 14 sample data document as the only data source for the first playable planning.

Required sample groups:
- visitor sample
- scenario sample
- check sample
- action sample
- result sample
- reward sample

## Minimal UI Order
```text
1. Queue area
2. Profile card
3. Action area
4. Result feedback area
5. Reward feedback area
```

## Test Gate Order
```text
1. Folder structure check
2. Sample data check
3. UI boundary check
4. Minimum loop check
5. Scope guard check
6. Freeze decision
```

## Scope Guard
Do not add:
- advanced systems
- full catalogs
- final art
- production audio
- release workflow

## Next Step
After Stage 14 freeze, Codex can be used for controlled implementation planning or first shell tasks only.
