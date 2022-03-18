using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Combatant
{
    //This character shall attack another
    public void attack(GameChar opp);
}
