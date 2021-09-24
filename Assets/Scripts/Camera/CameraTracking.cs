using UnityEngine;

namespace PlayerDefinition
{
    public class CameraTracking : MonoBehaviour
    {
        [SerializeField]private Player _player;
        private Vector3 offset;
        private void Start()
        {
            
        }
        private void Update()
        {
            offset = transform.position - _player.transform.position;
        }
        private void LateUpdate()
        {
            transform.position = _player.transform.position + offset;
            float rotation = Input.GetAxis("Mouse X");
            transform.RotateAround(_player.transform.position, Vector3.up, rotation);
        }
    }
}