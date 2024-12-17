using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GameUtils 
{
    public static string DiscribeItem<T>(T something)
    {
        return ("This item is a " + something);
    }
}
