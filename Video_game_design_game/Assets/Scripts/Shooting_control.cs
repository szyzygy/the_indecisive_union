using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_control : MonoBehaviour
{

    public GameObject bullet_prefab;
    public GameObject end_of_barrel;
    public float refire_time;
    private Transform EOB;
    
    private float shot_stopwatch;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Shoot_gun()
    {
        if (shot_stopwatch + refire_time <= Time.time) {

            shot_stopwatch = Time.time;
            Instantiate(bullet_prefab, end_of_barrel.transform);
        }

    }



}
