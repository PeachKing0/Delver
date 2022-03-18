using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dungeon : MonoBehaviour
{
    //Fields
    Room[][] rooms; //Is jagged
    public int diff;
    string name;

    //Generate new random dungeon
    public Dungeon(int diff, string name)
    {
        this.diff = diff;
        this.name = name;

        //Generate number of levels
        //Jagged array to allow for lower levels to have more rooms
        int numLvls = Dice.RollDice(1, 4) + diff; //Number of levels
        rooms = new Room[numLvls][];

        int numRms = Dice.RollDice(1, 2); //Number of rooms on level
        //Generate number of rooms in each level
        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i] = new Room[numRms];

            //Fill level with rooms
            for (int j = 0; j < rooms[i].Length; j++)
                rooms[i][j] = new Room(diff);

            //Next levl adds 0, 1, or 2 more rooms
            numRms += Dice.RollDice(1, 3) - 1;
        }

        //Decide a random room in each level to have the stairs down
        //Stairs location not yet a requirement for advancing to lower levels
        foreach (Room[] r in rooms)
        {
            int stairsIndex = Dice.RollDice(1, r.Length) - 1;
            r[stairsIndex].hasStairs = true;
        }
    }

    //Prints the dungeon unto minimap for player to easily see what remains
    public void printDungeon()
    {
        print(name);
        //Minimap not yet implemented
    }
}
