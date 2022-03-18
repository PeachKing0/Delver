using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public static int RollDice(int dice, int sides)
    {
        int sum = 0;
        for (int i = 0; i < dice; i++)
            sum += Random.Range(1, 6) + 1;
        return sum;
    }

    public static string GetRandToken(string[] tokens)
    {
        int randIndex = Random.Range(0, tokens.Length);
        return tokens[randIndex];
    }

    //To Do: Random name generation
    public static string randName()
    {
        string name = "";

        return name;
    }
}
