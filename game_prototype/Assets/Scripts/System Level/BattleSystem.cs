using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This battle Manager takes care of the ATB system and allowing characters to move and such. 
public class BattleSystem : MonoBehaviour
{
    public int incrementPerTick;
    public List<Character> allEntities;
    public List<Character> enemies;
    public List<Character> allies;



    public bool startBattle;
    private bool isPaused;


    private void Awake() {
        foreach (Character chara in allEntities)
        {
            chara.stats.currentATB = 0; 
        }
    }

    private void Start() {
        OnBattleEnter();
    }

    // This is for starting the battle, any animations and such go in here. 
    public void OnBattleEnter()
    {
        // When finished, calls the StartBattle() function
        //startBattle = true;
        print("Starting game");
    }

    public void Update()
    {
        if (!startBattle) { return; }
        if (isPaused) { return; }
        UpdateATB();
    }
    

    

    // This is for ending the battle, any animations and loops go here. 
    public void OnBattleEnd()
    {
        
    }

    public void ShowUI()
    {
        // This would be an individual UI interface or component. 
    }

    // This function updates each character's ATB
    public void UpdateATB()
    {
        allEntities.ForEach(delegate(Character chara) { chara.UpdateATB(Time.deltaTime); });
    }

    public void CheckPlayerTurn()
    {
        allEntities.ForEach(delegate(Character chara) { 
            if (chara.isReady) 
            { 
                ToggleATB();
            }; 
        });
    }

    // This function is called for either pausing game or the player's turn.
    public void ToggleATB()
    {
        isPaused = !isPaused;
    }


    public void Initialize(List<Character> players, List<Character> enemies, List<Character> other = null)
    {
        allies = new List<Character>();
        allies.AddRange(players);
        this.enemies = new List<Character>();
        this.enemies.AddRange(enemies);
        allEntities.AddRange(allies);
        allEntities.AddRange(enemies);

        if (other == null) { return; }
        allEntities.AddRange(other);
    }


    public void SpawnCharacters()
    {
        
    }
}
