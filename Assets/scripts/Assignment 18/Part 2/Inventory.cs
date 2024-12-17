using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<string> lis = new List<string>();

    public void AddItem(string item)
    {
        lis.Add(item);
    }

    public void ShowItem()
    {
        foreach (string n in lis)
        {
            Debug.Log(n);
        }
    }

    public static Inventory operator + (Inventory potion , Inventory elixirs)
    {
        Inventory combine = new Inventory();
        foreach (string n in potion.lis)
        {
            combine.AddItem(n);
        }
        foreach (string n in elixirs.lis)
        {
            combine.AddItem(n);
        }

        return combine;
    }
}
