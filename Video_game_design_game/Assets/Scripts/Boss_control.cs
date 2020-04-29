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
    public GameObject boss_image;
    public GameObject bos_alt;
    public GameObject bos_norm;
    public bool in_range;
    public bool travel_reached;
    public bool health_ready;
    public int health;
    public int frame_c = 0;



    void Start()
    {
        destination_picker(travel_points, travel_points[1]);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(this.gameObject.transform.position, player.gameObject.transform.position);
        if (health_ready && frame_c >=10) {

            boss_image.GetComponent<UnityEngine.UI.Image>().sprite = bos_norm.GetComponent<UnityEngine.UI.Image>().sprite;
        }

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

    void cause_death()
    {



        boss.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
        boss.GetComponent<UnityEngine.AI.NavMeshAgent>().Warp(death_point.transform.position);


    }


    public void OnTriggerEnter(Collider other)
    {
        int i = health;

        if (other.gameObject.tag == "bullet")
        {

            // add code to reduce health per bullet here
            // bullet is the other.gameobject

            if (i <= 0)
            {
                cause_death();
            }
            else {

                boss_image.GetComponent<UnityEngine.UI.Image>().sprite = bos_alt.GetComponent<UnityEngine.UI.Image>().sprite;
            }

            i--;

        }
    }


}
