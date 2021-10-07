using UnityEngine;
namespace RollABall
{
    public class GameController : MonoBehaviour
    {
        private ListExecuteObjects _interactiveObjects;
        private CameraController _cameraController;
        private void Awake()
        {
            var references = new References();

            _interactiveObjects = new ListExecuteObjects();
            _cameraController = new CameraController(references.PlayerBall, references.MainCamera.transform);     

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
            //Add bonus
        }
        private void GoodBonusEffect(object value)
        {
            //Add bonus
        }
    }
}