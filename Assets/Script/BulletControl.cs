using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    static public bool isAttack = false;
    public float DestroyTime;
    public float BulletMoveSpeed;
    public GameObject Burn;

    void Start()
    {
        Burn.GetComponent<ParticleSystem>().enableEmission = false;
    }

    void Update()
    {
        decideAttack();
    }

    void decideAttack()
    {
        if (isAttack == true)
        {
            transform.Translate(0, 0, BulletMoveSpeed * Time.deltaTime);
        }
        Destroy(gameObject, DestroyTime);
    }

    void OnTriggerEnter(Collider TriggerObj)
    {
        if (TriggerObj.tag == "Monster")
        {
            Burn.GetComponent<ParticleSystem>().enableEmission = true;
            robot_blood.Mblood[0] -= 1;
        }
        else if (TriggerObj.tag == "Monster02")
        {
            Burn.GetComponent<ParticleSystem>().enableEmission = true;
            robot_blood.Mblood[1] -= 1;
        }
        else if (TriggerObj.tag == "Monster00")
        {
            Burn.GetComponent<ParticleSystem>().enableEmission = true;
            robot_blood.Mblood[2] -= 1;
        }
        else if (TriggerObj.tag == "Monster03")
        {
            Burn.GetComponent<ParticleSystem>().enableEmission = true;
            robot_blood.Mblood[3] -= 1;
        }
        else if (TriggerObj.tag == "Monster04")
        {
            Burn.GetComponent<ParticleSystem>().enableEmission = true;
            robot_blood.Mblood[4] -= 1;
        }
        else if (TriggerObj.tag == "Monster05")
        {
            Burn.GetComponent<ParticleSystem>().enableEmission = true;
            robot_blood.Mblood[5] -= 1;
        }
    }
}
