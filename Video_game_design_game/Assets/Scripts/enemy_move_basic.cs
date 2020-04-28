using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_basic : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;



    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = player.gameObject.transform.position;
    }
}
