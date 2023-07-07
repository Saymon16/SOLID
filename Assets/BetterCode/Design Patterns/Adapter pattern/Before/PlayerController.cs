using UnityEngine;

namespace AdapterPattern_Before
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed;
        public bool UseMouse;

        void Update()
        {
            Vector3 mouseInputVector = new Vector3(Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y"));
            Vector3 joypadInputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Horizontal"));

            Vector3 inputVector = UseMouse ? mouseInputVector : joypadInputVector;

            transform.position += inputVector * ( Speed  * Time.deltaTime );
        }
    }
}