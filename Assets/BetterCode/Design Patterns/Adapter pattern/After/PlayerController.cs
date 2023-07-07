using System;
using UnityEngine;

namespace AdapterPattern_After
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed;
        private IProvideInput _inputProvider;

        private void Awake()
        {
            _inputProvider = GetComponent<IProvideInput>();
        }

        void Update()
        {
            if (_inputProvider == null) return;

            Vector3 inputVector = _inputProvider.GetInputVector();
            transform.position += inputVector * ( Speed  * Time.deltaTime );
        }
    }

    public interface IProvideInput
    {
        Vector3 GetInputVector();
    }

    public class MouseInput : MonoBehaviour, IProvideInput
    {
        public Vector3 GetInputVector()
        {
            return new Vector3(Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y"));
        }
    }

    public class GamepadInput : MonoBehaviour, IProvideInput
    {
        public Vector3 GetInputVector()
        {
            return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Horizontal"));
        }
    }
}