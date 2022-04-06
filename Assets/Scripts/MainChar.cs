using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats 
{
    int str; //Strength: atk power
    int vit; //Vitality: toughness (hp)
    int dex; //Dexterity: spd/agility
    int wis; //Wisdom: inteligence (Max mana & mana regen rate)
    int armorRank; //Determines highest ranking armor that may be worn
    int weapRank; //Determins highest ranking weapon that may be used
    int xp; //Experience points

    public Stats(bool randomize)
        : this() //Set all stats to zero-equivalents
    {
        //If said stats must be randomized
        if(randomize)
        {
            //Randomize stats here
            int[] stats = new int[4];
            for (int i = 0; i < 4; i++)
                stats[i] = Dice.RollDice(1, 6);
            SetStr(stats[0]);
            SetVit(stats[1]);
            SetDex(stats[2]);
            SetWis(stats[3]);
        } 
        //If not then they remain zero-equivalent
    }

    public Stats()
    {
        str = 0;
        vit = 0;
        dex = 0;
        wis = 0;
        armorRank = 0;
        weapRank = 0;
        xp = 0;
    }

    #region Getters and Setters
    public int GetStr()
    {
        return str;
    }

    public void SetStr(int str)
    {
        if (str >= 0) this.str = str;
    }

    public int GetVit()
    {
        return vit;
    }

    public void SetVit(int vit)
    {
        if (vit >= 0) this.vit = vit;
    }

    public int GetDex()
    {
        return dex;
    }

    public void SetDex(int dex)
    {
        if (dex >= 0) this.dex = dex;
    }

    public int GetWis()
    {
        return wis;
    }

    public void SetWis(int wis)
    {
        if (wis >= 0) this.wis = wis;
    }

    public int GetArmorRank()
    {
        return armorRank;
    }

    public void SetArmorRank(int rank)
    {
        if (rank >= 0) this.armorRank = rank;
    }

    public int GetWeapRank()
    {
        return weapRank;
    }

    public void SetWeapRank(int rank)
    {
        if (rank >= 0) this.weapRank = rank;
    }

    public int GetXp()
    {
        return xp;
    }

    public void SetXp(int xp)
    {
        if (xp >= 0) this.xp = xp;
    }
    #endregion
}

public class MainChar : GameChar
{
    //All GameChar fields are inherited (name, loc, etc.)
    public Stats stats;

    public MainChar()
    {
        stats = new Stats(true);
    }

    //Other MainChar stuff to be added

    public void SetEqualTo(MainChar other)
    {
        this.stats.SetXp(other.stats.GetXp());
        this.stats.SetStr(other.stats.GetStr());
        this.stats.SetDex(other.stats.GetDex());
        this.stats.SetVit(other.stats.GetVit());
        this.stats.SetWis(other.stats.GetWis());
        this.stats.SetArmorRank(other.stats.GetArmorRank());
        this.stats.SetWeapRank(other.stats.GetWeapRank());
        this.name = other.name;
        this.loc = other.loc;
        this.charType = other.charType;
        this.level = other.level;
        this.gold = other.gold;
        this.maxHp = other.maxHp;
        this.curHp = other.curHp;
    }
}
