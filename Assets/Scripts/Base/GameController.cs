using UnityEngine;
using PlayerDefinition;
public class GameController : MonoBehaviour
{
    private InteractiveObjects[] _interactiveObjects;
    private Player _player;
    private void BadBonusEffect(object value)
    {
        _player.Speed *= 0.5f;
    }private void GoodBonusEffect(object value)
    {
        _player.Speed *= 1.5f;
    }
    private void Awake()
    {
        _interactiveObjects = FindObjectsOfType<InteractiveObjects>();
        _player = FindObjectOfType<Player>();

        foreach (var i in _interactiveObjects)
        {
            if (i is BadBonus badBonus)
                badBonus.bonusEffect += BadBonusEffect;
            if (i is GoodBonus goodBonus)
                goodBonus.bonusEffect += GoodBonusEffect;
        }
    }
    private void Update()
    {
        for (int i = 0; i < _interactiveObjects.Length; i++) 
        {
            var interactiveObject = _interactiveObjects[i];
            if (_interactiveObjects[i] == null)
                continue;
            if (interactiveObject is IFly fly)
                fly.Fly();
        }
    }

    private void Dispose()
    {
        foreach (var i in _interactiveObjects)
        {
            if (i is BadBonus badBonus)
                badBonus.bonusEffect -= BadBonusEffect;
            if (i is GoodBonus goodBonus)
                goodBonus.bonusEffect -= GoodBonusEffect;
        }
    }
}
