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

    public void add_to_slot(int x)
    {
        
        int i = 0;
        foreach (GameObject item in inventory)
        {

            if (x == 0) { 
                    item.transform.SetParent(Barrels[i].transform);
                    

            }
            else if (x == 1)
            {
                item.transform.SetParent(reciver[i].transform);


            }
            else if (x == 2)
            {
                item.transform.SetParent(Stocks[i].transform);
                item.transform.position = Stocks[i].transform.position;


            }

            else if (x == 3)
            {
                item.transform.SetParent(unders[i].transform);


            }

            else if (x == 4)
            {
                item.transform.SetParent(scopes[i].transform);


            }



            i++;
        }

    }






}
