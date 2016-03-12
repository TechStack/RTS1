using UnityEngine;
using System.Collections;
using System;

public class Inventory : MonoBehaviour, IInventory
{


    public bool AddToFirstFreeSlot(IItemStackable item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool DecreaseStackSizeBy(int Slot, int Count)
    {
        throw new NotImplementedException();
    }

    public IItemStackable GetStackInSlot(int Slot)
    {
        throw new NotImplementedException();
    }

    public int GetStackSizeInSlot(int Slot)
    {
        throw new NotImplementedException();
    }

    public bool SetStackInSlot(IItemStackable item, int Slot)
    {
        throw new NotImplementedException();
    }
}
