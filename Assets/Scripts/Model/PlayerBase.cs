using UnityEngine;
namespace RollABall
{
    public abstract class PlayerBase : MonoBehaviour
    {
        internal float Speed { get; set; } = 3.0f;
        internal abstract void Move(Vector3 direction);
    }
}