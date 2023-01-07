using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    public class GameObjectRandomizer : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _gameObjectsList;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void CreateRandomGameObject()
        {
            var choosedGameobject = _gameObjectsList.GetRandomItem();
            Instantiate(choosedGameobject, transform);
        }
    }
}