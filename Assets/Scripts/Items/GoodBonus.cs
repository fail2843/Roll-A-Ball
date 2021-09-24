using UnityEngine;
internal sealed class GoodBonus : InteractiveObjects , IFly
{
    internal event SetBonusEffect bonusEffect;
 
    private void Awake()
    {
        groundOffset = 0.4f;
    }
    protected override void Interaction()
    {
        bonusEffect?.Invoke(this);
    }
    public void Fly()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, groundOffset)+groundOffset, transform.localPosition.z);
    }
}