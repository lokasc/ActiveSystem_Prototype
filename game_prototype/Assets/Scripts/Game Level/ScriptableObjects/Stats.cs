using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Statistics 
{
    // This class contains all of the revelant statistics that each player has.
    public float maxATB;
    public float currentATB; 

    public int maxhealthPoints;
    public int healthPoints;
    public int maxManaPoints;
    public int manaPoints;
    
    [Tooltip("This determines how fast a character can act or move")]
    public int speed;
    [Tooltip("How easily can a character dodge. Bigger window for dodging")]
    public int agility;

    
}