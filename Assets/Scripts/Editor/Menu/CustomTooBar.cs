using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public static class CustomTooBar
{
    [MenuItem("Ebac/Create Cube")]
    public static void CreateGameObject()
    {
        GameObjectFromTooBar.CreateGameObject();
    }
}

public class GameObjectFromTooBar : MonoBehaviour
{
    public static void CreateGameObject()
    {
        Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube), Vector3.zero, new Quaternion(0,0,0,0));
    }
}