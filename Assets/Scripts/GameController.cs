using UnityEngine;
namespace RollABall
{
    public class GameController : MonoBehaviour
    {
        private References _references;
        private ListExecuteObjects _interactiveObjects;
        private CameraController _cameraController;
        private void Awake()
        {
            _references = new References();

            _interactiveObjects = new ListExecuteObjects();
            _cameraController = new CameraController(_references.PlayerBall, _references.MainCamera.transform);     

            _interactiveObjects.AddExecuteObject(_cameraController);          

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
        private void BadBonusEffect(object value)
        {
            _references.PlayerBall.Speed *= 0.5f;
        }
        private void GoodBonusEffect(object value)
        {
            _references.PlayerBall.Speed *= 1.5f;
        }
    }
}