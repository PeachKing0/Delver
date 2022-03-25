using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DexChar : MainChar
{
    public DexChar()
    {
        //Generate name aned gold
        name = Dice.RandName(Dice.RollDice(1, 2) + 1, 0.5f);
        gold = Dice.RollDice(8, 12);

        //Boost respective stats, then generate sub-class
        stats.SetDex(stats.GetDex() + 6);
        stats.SetVit(stats.GetVit() + 4);
        charType = Dice.GetRandToken(new string[] { "Rogue", "Ranger" });

        //Sub-Class specific benefits
        if (charType.Equals("Rougue"))
        {
            stats.SetArmorRank(1);
            stats.SetWeapRank(2);
            stats.SetDex(stats.GetDex() + 3);
        }
        else if (charType.Equals("Ranger"))
        {
            stats.SetArmorRank(2);
            stats.SetWeapRank(2);
            stats.SetVit(stats.GetVit() + 2);
        }
    }
}
