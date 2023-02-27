using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Cube : MonoBehaviour
{

    public GameObject cubePrefab;


    [MenuItem("MyMenu/InstantiateCube %g")]
    static void InstantiateCube()
    {
        Instantiate(GameObject.FindGameObjectWithTag("Cube"));
    }


}
