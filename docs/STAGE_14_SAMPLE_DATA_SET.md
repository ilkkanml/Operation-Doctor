# Operation: Doctor — Stage 14 Sample Data Set

## Purpose
This document defines the minimum sample data set for Stage 14 planning.

## Boundary
This is not a full content catalog.
This is only abstract game-system sample data for planning.

## Visitor Sample
Use 3 abstract visitor types:

```text
visitor_young_adult
visitor_middle_age
visitor_elder
```

Each visitor may include:
- display name placeholder
- age group
- priority level
- short status tags
- reward multiplier placeholder

## Scenario Sample
Use 3 abstract scenario groups:

```text
scenario_basic_status
scenario_pressure_status
scenario_minor_event
```

Each scenario may include:
- status tags
- needed check tags
- possible action tags
- risk level
- completion state

## Check Sample
Use 3 basic check types:

```text
check_temperature
check_pulse
check_pressure
```

Each check may include:
- duration value
- confidence value
- result range label
- ready state

## Action Sample
Use 3 basic action groups:

```text
action_observe
action_request_check
action_start_basic_flow
```

Each action may include:
- action type
- target scenario tag
- result trigger
- reward trigger

## Result Sample
Use 3 basic result states:

```text
result_success
result_waiting
result_failed
```

Each result may include:
- feedback text placeholder
- state change
- reward modifier

## Reward Sample
Use 3 reward fields:

```text
xp_reward
money_reward
reputation_reward
```

## Scope Guard
Do not add:
- Full catalog
- Real-world instruction details
- Full economy values
- Production balancing

## Next Step
Game & Systems should check whether this sample data supports the Stage 14 first playable flow.
