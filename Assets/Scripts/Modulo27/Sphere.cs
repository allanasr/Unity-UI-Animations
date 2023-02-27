using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    public GameObject spherePrefab;

    private List<Color> colors = new List<Color>();

    private Vector2 defaultPosition = Vector2.zero;

    private int numberSpawned = 0;

    private void Start()
    {
        colors = SphereColor.Instance.GetColors();
    }
    public void InstantiateSphere()
    {
        var s = Instantiate(spherePrefab);
        s.transform.position = defaultPosition + new Vector2(numberSpawned, 1);
        s.GetComponent<MeshRenderer>().material.SetColor("_Color", colors.RandomListObject());
        numberSpawned++;
    } 
}
