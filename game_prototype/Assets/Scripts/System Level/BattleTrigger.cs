using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

// Retrieves the current party and the list of characters.
// Preset Enemies that will be in the battle.
 
public class BattleTrigger : MonoBehaviour
{
    public EnemySet enemyList;
    public bool triggered;

    // Maybe we want to add the map limit? 



    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.name);
        if (!other.CompareTag("Player")) { return; }
        if (triggered) { return; }
        StartGame();
        triggered = true;
    }

    private void StartGame()
    {
        GameObject battleSystem = Instantiate(GameManager.instance.battleSystemPrefab);

        // Initializes the Battle.

        battleSystem.GetComponent<BattleSystem>().Initialize(GameManager.instance.playerData.party, enemyList.GetList());
    }
}
