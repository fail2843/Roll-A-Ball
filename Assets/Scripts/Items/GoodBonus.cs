using UnityEngine;
internal sealed class GoodBonus : InteractiveObjects
{
    protected override void Interaction()
    {
        Debug.LogWarning("This is a Good Bonus");
    }
}