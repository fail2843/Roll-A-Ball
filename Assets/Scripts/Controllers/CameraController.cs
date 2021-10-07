using UnityEngine;
namespace RollABall
{
    public class CameraController : IExecute
    {
        private Transform _player;
        private Transform _mainCamera;
        private Transform _cameraShell;
        private readonly PlayerBase _playerBase;
        private Vector3 _defaultOffset = new Vector3(0f, 1f, -2f);
        private Vector3 offset;
        public CameraController(PlayerBase player, Transform mainCamera)
        {
            _playerBase = player;
            _mainCamera = mainCamera;

            _cameraShell = _mainCamera.root;
            _player = _playerBase.transform;
            _cameraShell.position = _player.position + _defaultOffset;

            offset = _cameraShell.position - _player.position;
        }
        public void Execute()
        {
            var cameraRotationY = Input.GetAxis("Mouse X");
            var playerMovement = Input.GetAxis("Vertical");

            _cameraShell.position = _playerBase.transform.position + offset;           
            _mainCamera.RotateAround(_playerBase.transform.position, Vector3.up, cameraRotationY);


            _playerBase.Move(_mainCamera.forward * playerMovement);
        }
    }
}