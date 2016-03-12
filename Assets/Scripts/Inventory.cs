using UnityEngine;
using System.Collections;
using System;

public class Inventory : MonoBehaviour, IInventory
{

    public Texture2D Slot1;
    public Texture2D Slot2;
    public Texture2D Slot3;
    public Texture2D Slot4;
    public Texture2D Slot5;
    public Texture2D Slot6;
    public Texture2D Slot7;
    public Texture2D Slot8;
    public Texture2D Slot9;
    


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
