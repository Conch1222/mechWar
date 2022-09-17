using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour
{
    public GameObject projectile;
    public GameObject FireSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(FireSound, transform.position, Quaternion.identity);
            GameObject shootPoint = Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
