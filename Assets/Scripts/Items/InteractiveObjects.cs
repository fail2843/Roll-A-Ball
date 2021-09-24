using UnityEngine;
internal abstract class InteractiveObjects : MonoBehaviour
{
    public delegate void SetBonusEffect(object value);
    protected float groundOffset;
    protected abstract void Interaction();
    private void OnTriggerEnter(Collider other)
    {
        Interaction();
        Destroy(gameObject);
    }
}