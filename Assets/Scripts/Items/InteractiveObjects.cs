using UnityEngine;
internal abstract class InteractiveObjects : MonoBehaviour
{
    protected abstract void Interaction();
    private void OnTriggerEnter(Collider other)
    {
        Interaction();
        Destroy(gameObject);
    }
}