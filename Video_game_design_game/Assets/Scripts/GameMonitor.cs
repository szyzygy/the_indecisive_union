using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMonitor : MonoBehaviour
{

    float startTime;
    bool spawnBoss;
 
    void Start()
    {
        startTime = Time.time;
        spawnBoss = false;
    }

    void Update()
    {
        // Set canDoThis to true after 20 seconds have passed
        if (!spawnBoss  && Time.time - startTime > 80){
            spawnBoss = true;
            Debug.Log("Boss is Spawning");
        }
    }
}
