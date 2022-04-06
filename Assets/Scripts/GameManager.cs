using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Reflection;

public class GameManager : MonoBehaviour
{
    public GameObject CharPrefab; //Base object representing party members
    public GameObject objPlayer; //The object representing the player
    public GameObject[] objParty; //The objects representing the party
    private MainChar player; //Controlled by user
    private MainChar[] party; //other characters in adventuring party
    private int partyInd = 0; //index for the next char to join the party
    public Dungeon[] dungs; //Dungeons available to explore

    // Start is called before the first frame update
    void Start()
    {
        GenerateDungs();
        MakeNewChar();
        //objPlayer = player.gameObject;
        //print(player);
    }

    public MainChar MakeNewChar()
    {
        GameObject clone = Instantiate(CharPrefab);
        Component creamyGamer = Dice.GetRandChar();
        print(creamyGamer.GetType());
        clone.AddComponent(creamyGamer.GetType());
        print(clone.TryGetComponent<MainChar>(out MainChar cheam));
        print(clone.GetComponent<MainChar>());
        return null;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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

/*    public void CharSelect()
    {
        print("***Starting Characterr***");
        MainChar[] starterChars = { Dice.GetRandChar(), Dice.GetRandChar(), Dice.GetRandChar() };
        for (int i = 0; i < starterChars.Length; i++)
        {
            //Actual implemententation soon!
            print(starterChars[i]);
        }
    }*/

    //Runs on clicking button (recruits members to party)
    public void Recruit()
    {
        MainChar toRecruit = Dice.GetRandChar();
        party = new MainChar[Mathf.RoundToInt(player.stats.GetWis() / 8f) + 3];
        party[partyInd] = toRecruit;
        partyInd++;
    }
}
