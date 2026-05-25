using System.Collections.Generic;
using UnityEngine;

namespace OperationDoctor.Placeholder
{
    // Stage 16 T2 scaffold: assigned TextAsset references only, no full data system.
    public sealed class PlaceholderDataLoader : MonoBehaviour
    {
        [SerializeField]
        private TextAsset manifest;

        [SerializeField]
        private TextAsset[] sampleDataFiles;

        public string ManifestName => manifest == null ? string.Empty : manifest.name;

        public IReadOnlyList<string> GetAssignedSampleNames()
        {
            var names = new List<string>();

            if (sampleDataFiles == null)
            {
                return names;
            }

            for (var i = 0; i < sampleDataFiles.Length; i++)
            {
                var file = sampleDataFiles[i];
                if (file != null)
                {
                    names.Add(file.name);
                }
            }

            return names;
        }

        private void Awake()
        {
            var assignedCount = sampleDataFiles == null ? 0 : sampleDataFiles.Length;
            Debug.Log($"[PlaceholderDataLoader] Manifest='{ManifestName}', AssignedFiles={assignedCount}");
        }
    }
}
