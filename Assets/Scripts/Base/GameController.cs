using UnityEngine;
public class GameController : MonoBehaviour
{
    private InteractiveObjects[] _interactiveObjects;
    private void Awake()
    {
        _interactiveObjects = FindObjectsOfType<InteractiveObjects>();
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
}
