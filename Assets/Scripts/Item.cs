using UnityEngine;
using System.Collections;
using System;

public class Item : MonoBehaviour, IItemStackable
{
    public bool AddToStack(int count)
    {
        throw new NotImplementedException();
    }

    public bool AddToStack(IItemStackable inItem)
    {
        throw new NotImplementedException();
    }

    public bool Use()
    {
        throw new NotImplementedException();
    }
}
