using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GameContainer<T> 
{
    public T item;
    public void SetItem(T item)
    {
        this.item =item;
    }
    public T GetItem()
    {
        return item ;
    }
}
