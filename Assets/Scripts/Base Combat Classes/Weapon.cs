using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour, Item
{
    int rank; //The greater this num is, the greater the weapon, vice versa also applies
    string weapType; //What "class" can equip this (e.g. staff => mage, Sword => Warrior, etc.)

    public Weapon(int rank, string weapType)
    {
        this.rank = rank;
        this.weapType = weapType;
    }

    public Weapon()
        : this(0, "UnIdentified")
    {
        //Just because of this I don't like C#'s way of calling another constructor from an constructor
    }

    public bool CanEquip(int rank, MainChar survivor)
    {
        //Can the adventurer equip this weapon??
        return rank <= survivor.stats.GetWeapRank() && DoTypesMatch(survivor);
    }

    public bool DoTypesMatch(MainChar survivor)
    {
        if (weapType.Equals("staff") && survivor.charType.Equals("Mage")) return true;
        else if (weapType.Equals("sword") && survivor.charType.Equals("Warrior")) return true;
        else if (weapType.Equals("Shiv") && survivor.charType.Equals("Rogue")) return true;
        else return false;
    }
}
