using System.Collections;
using Object = UnityEngine.Object;
using System;
namespace RollABall
{
    public sealed class ListExecuteObjects : IEnumerator, IEnumerable
    {
        private IExecute[] _interactiveObjects;
        private int _index = -1;
        private InteractiveObjects _currentObject;

        public object Current => _interactiveObjects[_index];
        public int Length => _interactiveObjects.Length;
        public ListExecuteObjects()
        {
            var interactiveObjects = Object.FindObjectsOfType<InteractiveObjects>();
            for (int i = 0; i < interactiveObjects.Length; i++)
            {

                if (interactiveObjects[i] is IExecute interactiveObject)
                    AddExecuteObject(interactiveObject);
            }
        }
        public void AddExecuteObject(IExecute execute)
        {
            if (_interactiveObjects == null)
            {
                _interactiveObjects = new[] { execute };
                return;
            }
            Array.Resize(ref _interactiveObjects, _interactiveObjects.Length + 1);
            _interactiveObjects[Length - 1] = execute;
        }
        public bool MoveNext()
        {
            if (_index == _interactiveObjects.Length - 1)
            {
                Reset();
                return false;
            }
            _index++;
            return true;
        }
        public void Reset() => _index = -1;
        public IExecute this[int index]
        {
            get => _interactiveObjects[index];
            private set => _interactiveObjects[index] = value;
        }
        public IEnumerator GetEnumerator() => this;
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}