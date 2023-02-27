using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class Utils 
{
    public static T RandomListObject<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

}
