using UnityEngine;
using System.Collections;

public interface IItemStackable {

    bool Use();
    bool AddToStack(IItemStackable inItem);
    bool AddToStack(int count);

}
