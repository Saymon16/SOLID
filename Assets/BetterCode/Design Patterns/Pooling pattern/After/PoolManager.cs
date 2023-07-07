using System.Collections.Generic;
using UnityEngine;

namespace PoolingPattern_After
{
    public class PoolManager : MonoBehaviour
    {
        // Dictionary to hold the pools
        Dictionary<int, Queue<ObjectInstance>> poolDictionary = new Dictionary<int, Queue<ObjectInstance>> ();

        //singleton pattern
        static PoolManager _instance;

        public static PoolManager instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<PoolManager> ();
                }

                return _instance;
            }
        }

        // Function to create a new pool of GameObjects
        public void CreatePool(GameObject prefab, int poolSize)
        {
            // Use prefab's instance ID as the pool key
            int poolKey = prefab.GetInstanceID ();

            // Create an empty GameObject to hold the pool
            GameObject poolHolder = new GameObject (prefab.name + " pool");
            poolHolder.transform.parent = transform;

            // Create the pool if it does not yet exist
            if (!poolDictionary.ContainsKey (poolKey))
            {
                // Add a new pool to the pool dictionary
                poolDictionary.Add(poolKey, new Queue<ObjectInstance>());

                // Instantiate the GameObjects and add them to the pool
                for (int i = 0; i < poolSize; i++)
                {
                    ObjectInstance newObject = new ObjectInstance(Instantiate (prefab) as GameObject);
                    poolDictionary [poolKey].Enqueue (newObject);
                    newObject.SetParent (poolHolder.transform);
                }
            }
        }

        // Function to reuse a GameObject from a pool
        public GameObject ReuseObject(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            int poolKey = prefab.GetInstanceID ();

            // If the pool exists
            if (poolDictionary.ContainsKey (poolKey))
            {
                // Remove an object from the pool, reuse it, and add it back to the pool
                ObjectInstance objectToReuse = poolDictionary [poolKey].Dequeue ();
                poolDictionary [poolKey].Enqueue (objectToReuse);

                objectToReuse.Reuse (position, rotation);
                return objectToReuse.GetObject();
            }

            // If the pool does not exist, return null
            return null;
        }

        // Class for pool object instances
        public class ObjectInstance
        {
            GameObject _gameObject;
            Transform _transform;
            bool _hasPoolObjectComponent;
            PoolObject _poolObjectScript;

            public ObjectInstance (GameObject objectInstance)
            {
                _gameObject = objectInstance;
                _transform = _gameObject.transform;
                _gameObject.SetActive(false);

                // If the object has a PoolObject component, save a reference to it
                if (_gameObject.GetComponent<PoolObject>())
                {
                    _hasPoolObjectComponent = true;
                    _poolObjectScript = _gameObject.GetComponent<PoolObject>();
                }
            }

            // Return the instance's GameObject
            public GameObject GetObject()
            {
                return _gameObject;
            }

            // Function to reuse the object instance
            public void Reuse(Vector3 position, Quaternion rotation  )
            {
                // If the object has a PoolObject component, call its OnObjectReuse function
                if (_hasPoolObjectComponent)
                {
                    _poolObjectScript.OnObjectReuse ();
                }

                // Reactivate the object and set its position and rotation
                _gameObject.SetActive (true);
                _transform.position = position;
                _transform.rotation = rotation;
            }

            // Set the parent of the instance
            public void SetParent(Transform parent)
            {
                _transform.parent = parent;
            }
        }
    }
}