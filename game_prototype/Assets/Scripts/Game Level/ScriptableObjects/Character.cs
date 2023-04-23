using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

[CreateAssetMenu(fileName = "Char_", menuName = "Character", order = 0)]
public class Character : ScriptableObject
{
    
    public GameObject prefab; 

    // This boolean deals with being able to attack. 
    public bool isReady = false;

    public string charName;
    public Statistics stats;
 
    public List<Ability> abilities;
    public List<baseEffect> statuses;
    

    // Called when an attack is applied. 
    public void TakeDamage(float damage, bool isDirectDamage = false)
    {
        stats.healthPoints -= (int)damage;
    }

    public void AddStatus(baseEffect status)
    {
        // We probably want to add checks such as defensive statuses that block things 
        // Architecture (Offensive will be on attacking character side and defensive would be recieving damage side)
        statuses.Add(status);
    }

    
    public void Attack(float damage, Character target, List<baseEffect> statuses = null)
    {
        target.TakeDamage(damage);
        if (statuses == null) {return;}
        foreach(baseEffect _status in statuses)
        {
            target.AddStatus(_status);
        }
    }

    public void UpdateATB(float value)
    {
        if (stats.currentATB >= stats.maxATB) { isReady=true; return; }
        stats.currentATB += value;
    }

    public void onUse()
    {
        stats.currentATB = 0;
        isReady = false;
    }
}
