using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTrigger(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            take_damage();
        }
    }

    void take_damage()
    {
        health -= 1;
        if(health <= 0)
        {
            cause_death();
        }
    }

    void cause_death()
    {
        //Code for what happens on death
        //Frowny face- restart button?
        Debug.Log("The Player has died");
    }
}
