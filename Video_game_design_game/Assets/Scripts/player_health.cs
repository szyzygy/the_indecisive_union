using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public int health;
    public GameObject death_ui;
    public GameObject player;
    public GameObject rotator;


    public List<GameObject> health_ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.tag + other.gameObject.name);

        if(other.gameObject.tag == "enemy")
        {
            
            take_damage();
        }
    }

    void take_damage()
    {
        health -= 1;
        health_ui[health].SetActive(false);
        if (health <= 0)
        {
            cause_death();
        }
    }

    void cause_death()
    {
        death_ui.SetActive(true);
        player.GetComponent<Character_movement>().move_lock = true;
        rotator.GetComponent<Top_Down_cam_char_look>().halt_mouse_control = true;
    }
}
