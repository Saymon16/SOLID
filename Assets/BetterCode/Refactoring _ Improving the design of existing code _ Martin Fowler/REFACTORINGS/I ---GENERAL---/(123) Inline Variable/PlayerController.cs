using UnityEngine;

namespace InlineVariable_Before
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject target;
        public float interactionRange = 5f;

        public bool IsTargetInRange()
        {
            Vector3 vectorToTarget = transform.position - target.transform.position;
            float distanceToTarget = vectorToTarget.magnitude;
            bool isInRange = distanceToTarget < interactionRange;
            return isInRange;
        }
    }
}

namespace InlineVariable_After
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject target;
        public float interactionRange = 5f;

        public bool IsTargetInRange()
        {
            float distanceToTarget = ( transform.position - target.transform.position ).magnitude;
            return distanceToTarget < interactionRange;
        }
    }
}