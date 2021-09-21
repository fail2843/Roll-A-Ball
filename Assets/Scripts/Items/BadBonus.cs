
using UnityEngine;
internal sealed class BadBonus : InteractiveObjects
{
    protected override void Interaction()
    {
        //Позже вся информация будет вынесена в отдельный класс
        Debug.LogWarning("This is a Bad Bonus");
    }
}