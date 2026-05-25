using UnityEngine;

namespace OperationDoctor.Placeholder
{
    // Stage 16 smoke helper: drives placeholder coordinator only.
    public sealed class FirstPlayableFlowSmokeDriver : MonoBehaviour
    {
        [SerializeField] private FirstPlayableFlowCoordinator coordinator;
        [SerializeField] private bool autoStep = true;
        [SerializeField] private float stepIntervalSeconds = 1.5f;

        private float elapsed;

        private void Update()
        {
            if (!autoStep || coordinator == null)
            {
                return;
            }

            elapsed += Time.deltaTime;
            if (elapsed < stepIntervalSeconds)
            {
                return;
            }

            elapsed = 0f;
            coordinator.MoveNextPlaceholderState();
        }

        public void StepOnce()
        {
            if (coordinator == null)
            {
                return;
            }

            coordinator.MoveNextPlaceholderState();
        }
    }
}
