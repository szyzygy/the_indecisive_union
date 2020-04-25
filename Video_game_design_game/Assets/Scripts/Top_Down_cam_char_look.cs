using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_Down_cam_char_look : MonoBehaviour
{
    Vector2 mouse_look;
    Vector2 Smoothing;
    public float rotation_sensitivity = 2f;
    public float smoothing_factor = 2f;
    public bool halt_mouse_control;
    public GameObject top_camera;

    RaycastHit hit;
    Ray ray;
//*/


    public GameObject character;
    public GameObject gun_paerent;

    void Start()
    {
        
        //Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        if (!halt_mouse_control)
        {

             ray = top_camera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100))
            {
                character.transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }


            if (Input.GetMouseButtonDown(0)) { gun_paerent.GetComponent<Shooting_control>().Shoot_gun(); }

        }
    }











}


