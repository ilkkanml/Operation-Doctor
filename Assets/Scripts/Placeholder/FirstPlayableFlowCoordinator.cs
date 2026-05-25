using UnityEngine;

namespace OperationDoctor.Placeholder
{
    // Stage 16 T4 scaffold: placeholder flow transitions only.
    public sealed class FirstPlayableFlowCoordinator : MonoBehaviour
    {
        [SerializeField] private FirstPlayableBootstrap bootstrap;
        [SerializeField] private FirstPlayableUIPanelSkeleton uiSkeleton;
        [SerializeField] private PlaceholderDataLoader dataLoader;

        private void Start()
        {
            if (bootstrap == null)
            {
                Debug.LogWarning("[FirstPlayableFlowCoordinator] Missing bootstrap reference.");
                return;
            }

            ApplyCurrentStateToUI();
            Debug.Log($"[FirstPlayableFlowCoordinator] Placeholder flow started. Manifest='{GetManifestName()}'");
        }

        public void MoveNextPlaceholderState()
        {
            if (bootstrap == null)
            {
                return;
            }

            var nextState = GetNextState(bootstrap.CurrentState);
            bootstrap.SetState(nextState);
            ApplyCurrentStateToUI();
        }

        private void ApplyCurrentStateToUI()
        {
            if (bootstrap == null || uiSkeleton == null)
            {
                return;
            }

            uiSkeleton.ApplyState(bootstrap.CurrentState);
        }

        private string GetManifestName()
        {
            return dataLoader == null ? string.Empty : dataLoader.ManifestName;
        }

        private static FirstPlayableFlowState GetNextState(FirstPlayableFlowState current)
        {
            switch (current)
            {
                case FirstPlayableFlowState.QueueVisible:
                    return FirstPlayableFlowState.ProfileVisible;
                case FirstPlayableFlowState.ProfileVisible:
                    return FirstPlayableFlowState.ActionSelected;
                case FirstPlayableFlowState.ActionSelected:
                    return FirstPlayableFlowState.ResultVisible;
                case FirstPlayableFlowState.ResultVisible:
                    return FirstPlayableFlowState.DecisionPending;
                case FirstPlayableFlowState.DecisionPending:
                    return FirstPlayableFlowState.RewardVisible;
                default:
                    return FirstPlayableFlowState.QueueVisible;
            }
        }
    }
}
