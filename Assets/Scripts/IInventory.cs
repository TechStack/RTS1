using UnityEngine;
using System.Collections;

public interface  IInventory {

    IItemStackable GetStackInSlot(int Slot);
    bool SetStackInSlot(IItemStackable item, int Slot);
    void Clear();
    bool AddToFirstFreeSlot(IItemStackable item);
    bool DecreaseStackSizeBy(int Slot, int Count);
    int GetStackSizeInSlot(int Slot);

}
