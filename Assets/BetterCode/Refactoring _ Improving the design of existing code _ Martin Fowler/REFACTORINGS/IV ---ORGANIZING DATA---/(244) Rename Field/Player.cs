using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenameField_Before
{
    public class Player : MonoBehaviour
    {
        private float _rspd = 5.0f;

        void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            transform.position = transform.position + movement * (_rspd * Time.deltaTime);
        }
    }
}
namespace RenameField_After
{
    public class Player : MonoBehaviour
    {
        private float _playerRunSpeed = 5.0f;

        void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            transform.position = transform.position + movement * (_playerRunSpeed * Time.deltaTime);
        }
    }
}