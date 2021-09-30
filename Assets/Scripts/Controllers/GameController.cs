using UnityEngine;
namespace RollABall
{
    public class GameController : MonoBehaviour
    {
        private ListExecuteObjects _interactiveObjects;
        private CameraController _cameraController;
        private InputController _inputController;
        private PlayerBase _player;
        private void BadBonusEffect(object value)
        {
            // _player.Speed *= 0.5f;
        }
        private void GoodBonusEffect(object value)
        {
            //_player.Speed *= 1.5f;
        }
        private void Awake()
        {
            var references = new References();

            _interactiveObjects = new ListExecuteObjects();
            _cameraController = new CameraController(references.PlayerBall.transform, references.MainCamera.transform);
            _inputController = new InputController(references.PlayerBall);

            _interactiveObjects.AddExecuteObject(_cameraController);
            _interactiveObjects.AddExecuteObject(_inputController);

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
                if (_interactiveObjects[i] == null)
                    continue;
                _interactiveObjects[i].Execute();
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
}