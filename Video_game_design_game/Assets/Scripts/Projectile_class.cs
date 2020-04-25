using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_class : MonoBehaviour
{

    private Vector3 start_point;
    public float speed;
    public float max_distance;
    public float Damage;

    
    
    
    // Start is called before the first frame update
    void Awake()
    {
        start_point = this.transform.parent.position;
        this.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        move_update();
    }

    void move_update() {

        if (Vector3.Distance(start_point, transform.position) > max_distance) {

            Destroy(this.gameObject);

        } else {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
