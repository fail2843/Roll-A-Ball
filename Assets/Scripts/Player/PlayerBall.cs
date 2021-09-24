using UnityEngine;
namespace PlayerDefinition
{
    [RequireComponent(typeof(Rigidbody))]
    internal class PlayerBall : Player
    {
        private void Update()
        {
            Move();
        }
    }
}