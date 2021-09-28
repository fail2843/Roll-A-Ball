using UnityEngine;
namespace PlayerDefinition
{
    internal class Player : MonoBehaviour
    {
        protected Rigidbody rigidBody;
        internal float Speed { get; set; } = 3f;

        private void Start()
        {
            rigidBody = GetComponent<Rigidbody>();
        }
        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical"); 
            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
            rigidBody.AddForce(movement * Speed);
        }
    }
}