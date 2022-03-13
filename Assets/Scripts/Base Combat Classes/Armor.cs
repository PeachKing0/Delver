using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour, Item
{
    int rank; //The greater this num is, the greater the armor, vice versa also applies
    string armorType; //What "class" can where this (e.g. robe => mage, Steel => Warrior, etc.)

    public Armor(int rank, string armorType)
    {
        this.rank = rank;
        this.armorType = armorType;
    }

    public bool CanEquip(int rank, MainChar survivor)
    {
        return rank <= survivor.stats.GetArmorRank() && DoTypesMatch(survivor);
    }

    public bool DoTypesMatch(MainChar survivor)
    {
        if (armorType.Equals("staff") && survivor.charType.Equals("Mage")) return true;
        else if (armorType.Equals("sword") && survivor.charType.Equals("Warrior")) return true;
        else if (armorType.Equals("Shiv") && survivor.charType.Equals("Rogue")) return true;
        else return false;
    }
}
