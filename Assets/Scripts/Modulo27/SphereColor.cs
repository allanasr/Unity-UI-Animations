using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;

public class SphereColor : Singleton<SphereColor>
{
    public List<Color> colors = new List<Color>();
    
    public List<Color> GetColors()
    {
        return colors;
    }

}
