using UnityEngine;
namespace RollABall
{
    [RequireComponent(typeof(Rigidbody))]
    internal sealed class PlayerBall : PlayerBase
    {
        private Rigidbody _rigidbody;
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        internal override void Move(Vector3 direction)
        {
            _rigidbody.AddForce(direction * Speed);
            
        }
    }
}