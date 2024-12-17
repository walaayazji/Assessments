using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{

    void Start()
    {
        GameContainer<string> potion = new GameContainer<string>();
        potion.SetItem("Healing Potion");
        string discribe =potion.GetItem();

        Debug.Log("stored item: " + discribe);
        Debug.Log(GameUtils.DiscribeItem<string>(discribe));
    }

}
