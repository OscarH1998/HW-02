﻿using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Cube cube = (Cube)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Generate Color"))
        {
            cube.GenerateColor();
        }

        if (GUILayout.Button("Reset"))
        {
            cube.Reset();
        }
        
        if (GUILayout.Button("Duplicate"))
        {
            cube.Duplicate();
        }

        if (GUILayout.Button("Make Wall"))
        {
            cube.MakeWall();
        }

        GUILayout.EndHorizontal();
    }
}
