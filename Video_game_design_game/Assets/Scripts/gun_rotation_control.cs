using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_rotation_control : MonoBehaviour
{

    public GameObject rot_center_guide;
    public GameObject gun_parent_canvas;
    private Vector3 left_facing_scale_vec = new Vector3(1f,1f,1f);
    private Vector3 right_facing_scale_vec = new Vector3(-1f, 1f, 1f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rot_center_guide.transform.rotation.y == 0)
        {

            gun_parent_canvas.GetComponent<RectTransform>().localScale = left_facing_scale_vec;

        }
        if (rot_center_guide.transform.rotation.y == 180)
        {

            gun_parent_canvas.GetComponent<RectTransform>().localScale = right_facing_scale_vec;

        }
    }
}
