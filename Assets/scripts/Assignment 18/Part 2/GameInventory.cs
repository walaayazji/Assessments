using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory potion = new Inventory();
        Inventory elixirs = new Inventory();

        potion.AddItem("Healing Potion");
        potion.AddItem("Strength Potion");

        elixirs.AddItem("Dark Elixirs");
        elixirs.AddItem("Elixirs");

        Inventory combine =potion + elixirs;
        combine.ShowItem();

    }

}
