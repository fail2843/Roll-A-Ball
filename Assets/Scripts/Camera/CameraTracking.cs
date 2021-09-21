using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerDefinition
{
    public class CameraTracking : MonoBehaviour
    {
        [SerializeField] Player player;
        private Vector3 offset;
        private void Start()
        {
            offset = transform.position - player.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = player.transform.position + offset;
        }
    }
}