using UnityEngine;

public abstract class GameChar : MonoBehaviour
{
    public string name;
    public string loc; //Location
    public string charType; //The class type(e.g. rogue, mage, etc.)
    public int level; //Determins dungeon access in MainChar
    public int gold; //Spending money in MainChar, reward in Monster
    public int maxHp;
    public int curHp;
}