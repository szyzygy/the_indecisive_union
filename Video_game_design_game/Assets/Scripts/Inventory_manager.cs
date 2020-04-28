using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_manager : MonoBehaviour
{


    public Transform R_parent;
    public Transform St_parent;
    public Transform B_parent;
    public Transform U_parent;
    public Transform Sc_parent;

    public List<GameObject> inventory;
    public List<GameObject> reciver;
    public List<GameObject> Stocks;
    public List<GameObject> Barrels;
    public List<GameObject> unders;
    public List<GameObject> scopes;
    public GameObject player;

    private void Start()
    {
        make_slot_list();
    }

    public void make_slot_list()
    {
        foreach (Transform slot in R_parent)
        {
            reciver.Add(slot.gameObject);
        }

        foreach (Transform slot in B_parent)
        {
            Barrels.Add(slot.gameObject);
        }

        foreach (Transform slot in St_parent)
        {
            Stocks.Add(slot.gameObject);
        }

        foreach (Transform slot in U_parent)
        {
            unders.Add(slot.gameObject);
        }

        foreach (Transform slot in Sc_parent)
        {
            scopes.Add(slot.gameObject);
        }

    }

    public void add_to_slot()
    {
        
        int i = 0;
        foreach (GameObject item in inventory)
        {
            List<GameObject> hold = new List<GameObject>();

            switch (item.transform.GetChild(0).GetComponent<mod_identity_class>().component_location)
            {
                case 0:
                    hold = Barrels;
                    break;
                case 1:
                    hold = reciver;
                    break;
                case 2:
                    hold = Stocks;
                    break;
                case 3:
                    hold = unders;
                    break;
                case 4:
                    hold = scopes;
                    break;
            }

            item.transform.SetParent(hold[i].transform);
            item.transform.position = hold[i].transform.position;
            item.GetComponentInChildren<Rigidbody>().useGravity = false;
            //item.GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            i++;
        }

    }






}
