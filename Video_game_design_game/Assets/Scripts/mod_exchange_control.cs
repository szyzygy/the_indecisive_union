using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mod_exchange_control : MonoBehaviour
{
    public GameObject player;
    public GameObject gun_parent;
    public List<GameObject> gun_components;
    public bool in_inventory;
    public GameObject inventory;
    public List<GameObject> active_mods;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<= 5; i++)
        {
            active_mods.Add(new GameObject());
        }


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
        if (in_inventory)
        {
            exchange_mod(this.GetComponent<UnityEngine.UI.Image>(), this.GetComponent<mod_identity_class>().component_location);
            active_mods[this.GetComponent<mod_identity_class>().component_location] = this.gameObject;
        }
        else {


            add_obj_inventory(this.gameObject);
            in_inventory = true;


            // add code here to send the parent to inventory, need both to appear to viewer.
            // once in inventory set the in inventory bool to true and clicking it will do a swap
            // also add a distance check here so player cannot pick up stuff from across tha map.
        }


    }


    public void add_obj_inventory(GameObject obj)
    {

        inventory.GetComponent<Inventory_manager>().inventory.Add(obj.transform.parent.gameObject);
        inventory.GetComponent<Inventory_manager>().add_to_slot();

    }

    //*

    //*/
}
