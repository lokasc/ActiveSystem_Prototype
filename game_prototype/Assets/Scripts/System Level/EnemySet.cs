using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySet_", menuName = "EnemySet", order = 0)]
public class EnemySet : ScriptableObject {

    public string presetName;
    public List<Character> Enemies;

    // We also want to specify spawn position
    

    [Tooltip("Picks a number of random characters in the list")]
    public bool isRandom;
    [Tooltip("The number of random enemies picked")]
    public int randomCount;

    // Returns a list of characters
    public List<Character> GetList()
    {
        if (isRandom)
        {
            if (randomCount != 0 || randomCount < Enemies.Count)
            {
                List<Character> _char = new List<Character>();
                for (int i = 0; i< randomCount; i++)
                {
                    int index = Random.Range (0, Enemies.Count);
                    _char.Add(Enemies[index]);
                }
                return _char;
            }
        }
        return Enemies;
    }
}
