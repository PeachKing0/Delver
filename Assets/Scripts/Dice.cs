using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private void Start()
    {
        print(RandName(2, 0.5f));
    }

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
    public static string RandName(int len, double hard)
    {
        //len = length of name
        //hard = how hard syyable should be
        //e.g. 1.0 is all hard, 0.0 is all soft, 0.5 is split

        string name = "";

        //runs once per syyable
        for (int i = 0; i < len; i++)
        {
            print(name);
            //80% of the time, starts with con
            if (Random.Range(0f, 1f) < 0.8f)
            {
                //Starts with consonant
                if (Random.Range(0f, 1f) < hard)
                    name += GetLetter('h');
                else
                    name += GetLetter('s');
                //30% of the time, softCon follows starting letter
                //if (Random.Range(0f, 1f) < 0.3f)
                    //name += GetLetter('s');
            }

            //Vowel
            name += GetLetter('v');

            //90% of the time, syllable ends with consonant(s)
            if (Random.Range(0f, 1f) < 0.9f)
            {
                if (Random.Range(0f, 1f) < 0.8f)
                    name += GetLetter('s');
                else
                    name += GetLetter('h');
            }
        }

        return name;
    }

    public static string GetLetter(char type)
    {
        string[] vowels = {"A", "E", "I", "O", "U"};
        string[] softCon = {"R", "L", "M", "N", "S"};
        string[] hardCon = {"G", "T", "W", "P", "D", "G", "K", "C", "X", "B", "V"};
        if (type == 'v')
            return GetRandToken(vowels);
        else if (type == 's')
            return GetRandToken(softCon);
        else if (type == 'h')
            return GetRandToken(hardCon);
        else
            return "ERROR"; //If name contains "ERROR" then something went wrong
    }
}
