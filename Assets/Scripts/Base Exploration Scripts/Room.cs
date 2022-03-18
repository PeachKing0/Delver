using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public bool isRevealed;
    public bool hasStairs;
    char display;
    string entranceMsg;
    int size;
    public string roomType;
    public int diff;
    public Monster[] mons;

    public Room(int diff)
    {
        //Set difficulty and room as hidden
        this.diff = diff;
        this.isRevealed = false;

        //Generate random size
        size = Dice.RollDice(1, 3);

        //Room contents start as mystery
        display = '?';
    }

    //ToString mainly used for minimap
    public string toString()
    {
        string txt = "[";
        for (int i = 0; i < size; i++)
            txt += display;
        return txt + "]";
    }

    public int EnterRoom()
    {
        print(entranceMsg);

        //Determine room type
        if (display == 'M')
        {
            //Generate monsters
            mons = new Monster[Dice.RollDice(1, size * 2)];
            for (int i = 0; i < mons.Length; i++)
                mons[i] = new Monster(diff);
        }
        else if (display == 'T')
            print("The traps part of this game hasn't been built yet, so don't worry about it");
        if (display == 'P')
            print("You solve a puzzle and get 100 gold! //Not yet implemented");
        if (display == 'R')
        {
            int gold = Dice.RollDice(4 * size, 6);
            print("You find some treasure and get " + gold + "gold!");
            return gold;
        }
        return 0;
    }

    //Once room revealed, generate it's room type
    public void GenRoomType()
    {
        //Room types: Trap, Puzzle, Monster, Reward
        float randRoom = Random.Range(0f, 1f);

        //Monster is most common type
        if (randRoom < 0.5f)
        {
            //Monster type chosen
            //Generate random number of monsters
            roomType = "Monsters";
            entranceMsg = "This room contains monsters!";
            display = 'M';
            mons = new Monster[Dice.RollDice(1, diff * 2)];

            //Fill monster array with random monsters
            for (int i = 0; i < mons.Length; i++)
                mons[i] = new Monster(diff);
        }
        else if (randRoom < 0.7f)
        {
            //Trap type chosen
            display = 'T';
            entranceMsg = "This room is trapped!";
        }
        else if (randRoom < 0.9f)
        {
            //Reward type chosen;
            display = 'R';
            entranceMsg = "This room contains treasure!";
        }
        else
        {
            //Puzzle type chosen
            display = 'P';
            entranceMsg = "This room contains a puzzle";
        }
    }
}
