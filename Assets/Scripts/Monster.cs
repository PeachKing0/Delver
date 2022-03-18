using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : GameChar, Combatant
{
    public Monster(int level)
    {
        this.level = level; //Monster level equal to room difficulty
        string[] lev1 = {"Rat", "Goblin", "Skeleton", "Zombie"};
        string[] lev2 = {"Orc", "Wolf"};
        string[] lev3 = {"Bear", "Ogre"};
        if (level == 1) name = Dice.GetRandToken(lev1);
        else if (level == 2) name = Dice.GetRandToken(lev2);
        else if (level == 3) name = Dice.GetRandToken(lev3);
        maxHp = Dice.RollDice(level, 8);
        curHp = maxHp;
    }

    public void attack(GameChar toDmg)
    {
        //implement attacking here
    }
}
