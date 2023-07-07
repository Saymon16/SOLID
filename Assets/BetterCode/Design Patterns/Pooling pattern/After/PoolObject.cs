using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PoolingPattern_After
{
    public class PoolObject : MonoBehaviour
    {

        public virtual void OnObjectReuse ()
        {

        }

        protected void Dispose()
        {
            gameObject.SetActive (false);
        }
    }
}