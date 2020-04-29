﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_control : MonoBehaviour
{

    private Vector3 start_point;

    // Start is called before the first frame update
    void Awake()
    {
        start_point = this.transform.parent.position;
        this.GetComponent<enemy_move_basic>().player = this.transform.parent.GetComponentInParent<Boss_control>().player;
        this.transform.parent = null;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}