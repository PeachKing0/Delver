using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainChar", menuName = "GameChar/MainChar")]
public class MainChar : GameChar
{
    int str;
    int con;
    int dex;
    int armorRank;
    int weapRank;
    int cp;
    //Item[] inv;

    public MainChar()
    {
        name = null;
        loc = null;
        charType = null;
        lvl = 1;
        armorRank = weapRank = 0;
        //rollStats();
        //inv = new Item[str + 5];
        maxHp = con * 2 + 10;
        curHp = maxHp;
    }

    //public void rollStats() {
    //    
    //}
}
