using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_control : MonoBehaviour
{

    public GameObject player;
    public GameObject boss;
    public GameObject destination;
    public GameObject Spawns;
    public GameObject sp_point;
    public List<GameObject> travel_points;
    public GameObject death_point;
    public bool in_range;
    public bool travel_reached;
    public bool spawn_ready;



    void Start()
    {
        destination_picker(travel_points, travel_points[1]);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(this.gameObject.transform.position, player.gameObject.transform.position);

        if (distance <= 50f)
        {
            in_range = true;
            boss.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = player.gameObject.transform.position;
            
        } else if (distance >= 250f) {

            boss.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = player.gameObject.transform.position;
            
        }
        else
        {
            in_range = false;
            boss.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = destination.gameObject.transform.position;
        }
        
        if (boss.GetComponent<UnityEngine.AI.NavMeshAgent>().remainingDistance <= boss.GetComponent<UnityEngine.AI.NavMeshAgent>().stoppingDistance) {

            destination_picker(travel_points, destination);
            spawn_attack(2);


        }
    }

    public void destination_picker(List<GameObject> dest, GameObject arrived) {

        dest.Remove(arrived);
        destination = dest[Random.Range(0, dest.Count)];
        dest.Add(arrived);


    }

    public void spawn_attack(int x) {

        for (int i = 0; i <x; i++) {

            Instantiate(Spawns, sp_point.transform);

        }



    }


}
