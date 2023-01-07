using Assets.Scripts.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(GameObjectRandomizer))]
public class RandomGameObjectsCreator : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GameObjectRandomizer gameObjectRandomizer = (GameObjectRandomizer)target;

        if(GUILayout.Button("Create random Gameobject"))
        {
            gameObjectRandomizer.CreateRandomGameObject();
        }
    }
}
