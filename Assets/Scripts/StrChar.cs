using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrChar : MainChar
{
    public StrChar()
        : base()
    {
        //Generate name and gold
        name = Dice.RandName(Dice.RollDice(1, 2), 0.8f);
        gold = Dice.RollDice(5, 12);

        //Boost respective statsm then generate sub-class
        stats.SetStr(stats.GetStr() + 6);
        stats.SetVit(stats.GetVit() + 3);
        charType = Dice.GetRandToken(new string[] { "Fighter", "Barbarian" });

        //Sub-Class specific benefits
        if (charType.Equals("Fighter"))
        {
            stats.SetArmorRank(3);
            stats.SetWeapRank(3);
        }
        else if (charType.Equals("Barbarian"))
        {
            stats.SetArmorRank(1);
            stats.SetWeapRank(3);
            stats.SetStr(stats.GetStr() + 1);
            stats.SetVit(stats.GetVit() + 2);
        }
    }
}
