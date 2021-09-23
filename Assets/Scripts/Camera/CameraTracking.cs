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
        private void Log()
        {
            Debug.Log("Camera position:" + transform.position +
                        "\n Player position: "+ player.transform.position);
        }
        private void Update()
        {
            //float rotation = Input.GetAxis("Mouse X");
            //transform.RotateAround(player.gameObject.transform.position, Vector3.up, rotation);
            //if (Input.GetKey(KeyCode.F)) Log();
        }

        private void LateUpdate()
        {
            transform.position = player.transform.position + offset;
            
        }
    }
}