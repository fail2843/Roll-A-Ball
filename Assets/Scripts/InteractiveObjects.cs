using UnityEngine;
namespace RollABall
{
    internal abstract class InteractiveObjects : MonoBehaviour, IExecute
    {
        public delegate void SetObjectEffect(object value);
        protected float groundOffset;
        public abstract void Execute();
        protected abstract void Interaction();
        private void OnTriggerEnter(Collider other)
        {
            Interaction();
            Destroy(gameObject);
        }
    }
}