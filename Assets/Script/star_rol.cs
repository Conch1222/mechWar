using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star_rol : MonoBehaviour
{
    public float rospeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rospeed * Time.deltaTime);
    }
}
