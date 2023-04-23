using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Singleton, will store "default" world wide stuff
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject battleSystemPrefab;
    public PlayerData playerData;


    private void Awake() {
        if (instance != null && instance != this )
        {
            Destroy(this);
            return;
        }
        else
        {
            instance = this;
        }
        
    }
}
