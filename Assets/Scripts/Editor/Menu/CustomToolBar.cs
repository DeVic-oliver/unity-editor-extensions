using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public static class CustomToolBar
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
        GameObject.CreatePrimitive(PrimitiveType.Cube).name = "Custom Cube";
    }
}