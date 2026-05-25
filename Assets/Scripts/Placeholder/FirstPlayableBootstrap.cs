using UnityEngine;

namespace OperationDoctor.Placeholder
{
    // Stage 16 T1 scaffold: wiring-only bootstrap, no gameplay logic.
    public sealed class FirstPlayableBootstrap : MonoBehaviour
    {
        [SerializeField]
        private FirstPlayableFlowState initialState = FirstPlayableFlowState.QueueVisible;

        public FirstPlayableFlowState CurrentState { get; private set; } = FirstPlayableFlowState.None;

        private void Awake()
        {
            CurrentState = initialState;
            Debug.Log($"[FirstPlayableBootstrap] Placeholder initialized with state: {CurrentState}");
        }

        public void SetState(FirstPlayableFlowState nextState)
        {
            CurrentState = nextState;
            Debug.Log($"[FirstPlayableBootstrap] Placeholder state changed: {CurrentState}");
        }
    }
}
