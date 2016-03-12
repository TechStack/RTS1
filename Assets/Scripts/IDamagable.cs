using UnityEngine;
using System.Collections;

public interface IDamagable {

    bool Damage();// return true if was damaged
    bool Kill();
    int GetHealth();
    int SetHealth();

}
