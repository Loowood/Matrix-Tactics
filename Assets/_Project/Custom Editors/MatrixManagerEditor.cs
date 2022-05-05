using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MatrixManager))]
public class MatrixManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        MatrixManager matrixManager = (MatrixManager)target;

        if (GUILayout.Button("Generate"))
        {
            matrixManager.generateMatrix();
        } else if (GUILayout.Button("RAZ"))
        {
            matrixManager.razCubes();
        }
    }
}
