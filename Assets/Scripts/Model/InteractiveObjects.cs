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
            //Переделать.
            //Нужно проверить уничтожение объекта или выкинуть его из списка исполняемых
            Destroy(gameObject);

            Debug.LogError(gameObject.name);
            
        }
    }
}