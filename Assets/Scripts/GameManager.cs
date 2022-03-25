using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    MainChar player; //Controlled by user
    public MainChar[] party; //other characters in adventuring party
    Dungeon[] dungs; //Dungeons available to explore

    // Start is called before the first frame update
    void Start()
    {
        GenerateDungs();
        CharSelect();
        Recruit();
    }

    public void GenerateDungs()
    {
        dungs = new Dungeon[5];
        dungs[0] = new Dungeon(1, "The Dark Forest");
        dungs[1] = new Dungeon(2, "The Old Crypt");
        //COTID has variable difficulty from 2 - 3
        dungs[2] = new Dungeon(1 + Dice.RollDice(1, 2), "Cave of the Ice Dragon");
        //Later dungeons unknown
        //dungs[3] = new Dungeon(3 + Dice.RollDice(1, 2), " "); Name unknown
        //dungs[4] = new Dungeon(5 + Dice.RollDice(1, 2), "The Corrupt Plane");  Final dungeon is Esmarelda Final Boss
    }

    //To Do:
    public void CharSelect()
    {
        print("***Starting Characterr***");
        MainChar[] starterChars = {  };
    }

    //To DO:
    public void Recruit()
    {

    }
}
