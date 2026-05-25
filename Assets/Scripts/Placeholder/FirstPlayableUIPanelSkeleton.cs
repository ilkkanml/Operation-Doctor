using UnityEngine;

namespace OperationDoctor.Placeholder
{
    // Stage 16 T3 scaffold: boundary UI references only, no production UI systems.
    public sealed class FirstPlayableUIPanelSkeleton : MonoBehaviour
    {
        [Header("Boundary Panels")]
        [SerializeField] private GameObject queuePanel;
        [SerializeField] private GameObject profilePanel;
        [SerializeField] private GameObject actionPanel;
        [SerializeField] private GameObject resultPanel;
        [SerializeField] private GameObject rewardPanel;

        private void Awake()
        {
            ApplyState(FirstPlayableFlowState.QueueVisible);
        }

        public void ApplyState(FirstPlayableFlowState state)
        {
            SetPanelActive(queuePanel, state == FirstPlayableFlowState.QueueVisible);
            SetPanelActive(profilePanel, state == FirstPlayableFlowState.ProfileVisible);
            SetPanelActive(actionPanel, state == FirstPlayableFlowState.ActionSelected);
            SetPanelActive(resultPanel, state == FirstPlayableFlowState.ResultVisible);
            SetPanelActive(rewardPanel, state == FirstPlayableFlowState.RewardVisible);

            Debug.Log($"[FirstPlayableUIPanelSkeleton] Applied placeholder UI state: {state}");
        }

        private static void SetPanelActive(GameObject panel, bool isActive)
        {
            if (panel != null)
            {
                panel.SetActive(isActive);
            }
        }
    }
}
