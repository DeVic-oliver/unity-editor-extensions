using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    public class GameObjectRandomizer : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _gameObjectsList;

        public void CreateRandomGameObject()
        {
            var choosedGameobject = _gameObjectsList.GetRandomItem();
            Instantiate(choosedGameobject, transform);
        }

    }
}