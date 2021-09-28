using UnityEngine;
namespace RollABall
{
    internal sealed class GoodBonus : InteractiveObjects, IFly
    {
        internal event SetObjectEffect bonusEffect;
        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, groundOffset) + groundOffset, transform.localPosition.z);
        }
        public override void Execute()
        {
            Fly();
        }
        protected override void Interaction()
        {
            bonusEffect?.Invoke(this);
        }
        private void Awake()
        {
            groundOffset = 0.4f;
        }
    }
}