using UnityEngine;

namespace RollABall
{
    public class CameraController : IExecute
    {
        private Transform _player;
        private Transform _mainCamera;
        private Transform _cameraShell;
        private Vector3 offset;
        public CameraController (Transform player, Transform mainCamera)
        {
            _player = player;
            _mainCamera = mainCamera;
            _cameraShell = _mainCamera.root;
            //_mainCamera.LookAt(_player);
            _cameraShell.position = _player.position + new Vector3(2, 2, 2);
            offset = _mainCamera.position - _player.position;
        }
        public void Execute()
        {
            _cameraShell.position = _player.position + offset;
            //Параметр скорости через класс данных
            //_mainCamera.RotateAround(_player.position, Vector3.up, 3f);
        }
    }
}