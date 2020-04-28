using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_movement : MonoBehaviour
{


    CharacterController cr;
    public float move_speed;
    public bool move_lock;
    public GameObject inventory_ui;
    public bool menu_open;

    // Start is called before the first frame update
    void Start()
    {
        cr = GetComponent<CharacterController>();
        inventory_ui.GetComponent<Inventory_manager>().make_slot_list();
        //Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!move_lock)
            Move();

        if (Input.GetKeyDown(KeyCode.Escape))                       //open or close options menu
        {
            if (!menu_open)
            {

                menu_open = true;
                //move_lock = true;
                //inventory_ui.SetActive(true);
                inventory_ui.transform.GetChild(0).GetComponent<RectTransform>().localPosition = new Vector3(0,0,0);
            }
            else if (menu_open) {

                //move_lock = false;

                menu_open = false;

                inventory_ui.transform.GetChild(0).GetComponent<RectTransform>().localPosition = new Vector3(0, 0, -500000);

            }

        }


    }

    



    private void Move()
    {

        float horizontal_in = Input.GetAxis("Horizontal") * move_speed;
        float vertical_in = Input.GetAxis("Vertical") * move_speed;

        Vector3 move_forward = transform.forward * vertical_in;
        Vector3 move_sideways = transform.right * horizontal_in;

        cr.SimpleMove(move_forward + move_sideways);


    }


}
