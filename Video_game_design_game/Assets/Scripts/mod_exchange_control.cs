using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mod_exchange_control : MonoBehaviour
{
    public GameObject player;
    public GameObject gun_parent;
    public List<GameObject> gun_components;
    

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void exchange_mod(UnityEngine.UI.Image mod, int comp) {

        gun_components[comp].GetComponent<UnityEngine.UI.Image>().sprite = mod.sprite;



    }


    private void OnMouseDown()
    {
        exchange_mod(this.GetComponent<UnityEngine.UI.Image>(), 0);
    }

    //*
    public void OnCollision(Collision collision)
    {

        if (collision.gameObject == player)
        {
            exchange_mod(this.GetComponent<UnityEngine.UI.Image>(), 0);
        }
    }
    //*/
}
