using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is basically a save data and only one is present at all times.

[CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerData", order = 0)]
public class PlayerData : ScriptableObject {
    
    public List<Character> party;

    //Add Inventory and other related stuff here. 

}