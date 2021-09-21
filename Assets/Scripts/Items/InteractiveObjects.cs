using UnityEngine;
internal abstract class InteractiveObjects : MonoBehaviour
{
    protected abstract void Interaction();
    private void OnTriggerEnter(Collider other)
    {
        //Специально нет сравнения по тегу. Бонусы может подбирать только игрок
        Interaction();
        Destroy(gameObject);
    }
}