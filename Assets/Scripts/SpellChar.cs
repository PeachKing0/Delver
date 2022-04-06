using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellChar : MainChar, Combatant
{
    public SpellChar()
        : base() //Equivalent to super(); | Calls parent constructor
    {
        //Generate name and gold
        name = Dice.RandName(Dice.RollDice(1, 1), 0.3f);
        gold = Dice.RollDice(10, 12);

        //Boost respective stats, then generated select sub-class
        stats.SetWis(stats.GetWis() + 7);
        charType = Dice.GetRandToken(new string[] { "Wizard", "Cleric", "Druid" });

        //Sub-Class specific benefits
        if (charType.Equals("Wizard"))
            stats.SetWis(stats.GetWis() + 5);
        else if (charType.Equals("Cleric"))
        {
            stats.SetArmorRank(3);
            stats.SetWeapRank(1);
            stats.SetWis(stats.GetWis() + 2);
            stats.SetVit(stats.GetVit() + 1); //Have to admit, encapsulation is a bit annoying for this
            stats.SetStr(stats.GetStr() + 1); //But it's for the best
        }
        else if (charType.Equals("Druid"))
        {
            stats.SetArmorRank(1);
            stats.SetWeapRank(1);
            stats.SetWis(stats.GetWis() + 3);
            stats.SetVit(stats.GetVit() + 2);
        }
    }

    //Deal dmg to opponent
    public void attack(GameChar opp)
    {
        //Not yet implemented
    }
}
