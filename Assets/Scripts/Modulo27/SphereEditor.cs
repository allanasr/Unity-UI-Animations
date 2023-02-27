using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Sphere))]
public class SphereEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Sphere myTarget = (Sphere)target;


        myTarget.spherePrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.spherePrefab, typeof(GameObject), true);


        if (GUILayout.Button("Create Sphere"))
        {
            myTarget.InstantiateSphere();
        }
    }
}
