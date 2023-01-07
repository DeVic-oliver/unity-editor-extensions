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
        GameObjectRandomizer gameObjectRandomizer = (GameObjectRandomizer)target;
        base.OnInspectorGUI();

        EditorGUILayout.ColorField(Color.white);

        if(GUILayout.Button("Create random Gameobject"))
        {
            gameObjectRandomizer.CreateRandomGameObject();
        }
    }
}
