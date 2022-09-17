using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star_coll : MonoBehaviour
{
    
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider CollisionDetection)
    {
        if (CollisionDetection.tag == "Player")
        {
            Destroy(star);
            star_cnt.countStar++;
        }
    }
}
