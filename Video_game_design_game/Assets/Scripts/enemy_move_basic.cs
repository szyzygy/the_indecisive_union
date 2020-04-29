using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_basic : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public GameObject death_point;
    public GameObject spawn_pooint;



    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = player.gameObject.transform.position;
    }

    void cause_death() {



        enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
        enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().Warp(death_point.transform.position);


    }


    private void OnCollisionEnter(Collision col)
    {

        print(col.gameObject.transform.GetChild(0).GetType().Name);

        if (col.gameObject.transform.GetChild(0).GetType().Name == "Projectile_class") {

            // add code here to deal units of damage to caise death
            cause_death();


        }


    }


}
