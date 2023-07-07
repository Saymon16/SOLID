using UnityEngine;

namespace ExtractVariable_Before
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject target;
        public float interactionRange = 5f;

        public bool IsTargetInRange()
        {
            return ( ( transform.position - target.transform.position ).magnitude < interactionRange );
        }
    }
}

namespace ExtractVariable_After
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject target;
        public float interactionRange = 5f;

        public bool IsTargetInRange()
        {
            float distanceToTarget = ( transform.position - target.transform.position ).magnitude;
            return ( distanceToTarget < interactionRange );
        }
    }
}