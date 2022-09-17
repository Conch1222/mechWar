using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_con : MonoBehaviour
{
    public GameObject Robot1;
    //public GameObject chara;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.3f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.3f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.3f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.3f);
        }
    }

    void OnTriggerEnter(Collider CollisionDetection)
    {
        if (CollisionDetection.tag == "range")
        {
            Robot1.GetComponent<robot_ani>().walk = true;
        }
        if (CollisionDetection.tag == "attack")
        {
            Robot1.GetComponent<robot_ani>().walk = false;
            Robot1.GetComponent<robot_ani>().attack = true;
        }
    }
    void OnTriggerExit(Collider CollisionDetection)
    {
        if (CollisionDetection.tag == "range")
        {
            Robot1.GetComponent<robot_ani>().walk = false;
        }
        if (CollisionDetection.tag == "attack")
        {
            Robot1.GetComponent<robot_ani>().walk = true;
            Robot1.GetComponent<robot_ani>().attack = false;
        }
    }
}
