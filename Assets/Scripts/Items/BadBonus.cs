using UnityEngine;
using PlayerDefinition;
internal sealed class BadBonus : InteractiveObjects
{
    private float _lengthFly;
    private Player _player;
    private void Awake()
    {
        _lengthFly = Random.Range(0f, 1f);
        _player = FindObjectOfType<PlayerBall>();
    }
    protected override void Interaction()
    {
        _player.Speed = 0f;
    }
    public void Fly()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthFly), transform.localPosition.z);
    }
}