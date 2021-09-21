using UnityEngine;
namespace PlayerDefinition
{
    public class Player : MonoBehaviour
    {
        protected float Hp = 10f;
        protected float Speed = 3f;
        protected Rigidbody rigidBody;
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