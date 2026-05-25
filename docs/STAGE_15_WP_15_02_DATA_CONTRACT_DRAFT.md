# Operation: Doctor — Stage 15 WP-15-02 Data Contract Draft

## Purpose
Define a controlled, docs-only data contract draft for first playable planning.

## Boundary
This draft is for shell-safe planning only.
No runtime gameplay implementation is included.

## Included Sample Groups
- visitor sample
- scenario sample
- check sample
- action sample
- result sample
- reward sample

## Field Naming Rules
- Use lower_snake_case for field keys.
- Use stable `id` values for each sample entry.
- Use abstract gameplay tags, not real-world clinical advice.
- Keep field sets minimal and testable.

## Draft Contract

### visitors
Required fields:
- `id`
- `display_name`
- `age_group`
- `priority_level`
- `status_tags`
- `reward_multiplier`

### scenarios
Required fields:
- `id`
- `status_tags`
- `required_check_tags`
- `possible_action_tags`
- `risk_level`
- `completion_state`

### checks
Required fields:
- `id`
- `duration_seconds`
- `confidence_score`
- `result_range_label`
- `ready_state`

### actions
Required fields:
- `id`
- `action_type`
- `target_scenario_tag`
- `result_trigger`
- `reward_trigger`

### results
Required fields:
- `id`
- `feedback_text`
- `state_change`
- `reward_modifier`

### rewards
Required fields:
- `xp_reward`
- `money_reward`
- `reputation_reward`

## Validation Notes
- Keep sample entry count small and fixed for first playable checks.
- Validate presence of required keys before any runtime integration.
- Reject fields that imply advanced systems outside first playable boundary.

## Out of Scope
- full production content catalog
- advanced staff/room/follow-up/economy systems
- final balancing and tuning
- gameplay runtime code and release workflows

## Outcome
This draft can be used as the single reference for placeholder data shape in controlled Stage 15 tasks.
