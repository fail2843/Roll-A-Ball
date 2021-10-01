using UnityEngine;
namespace RollABall
{
    //Wi-Fi Test
    [RequireComponent(typeof(Rigidbody))]
    internal sealed class PlayerBall : PlayerBase
    {
        private Rigidbody _rigidbody;
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        internal override void Move(float x, float y, float z)
        {
            _rigidbody.AddForce(new Vector3(x, y, z) * Speed);
        }
    }
}