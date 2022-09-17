using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_ani : MonoBehaviour
{
    Animator AnimatorRobot;
    public bool Idle, walk, attack;
    public Transform player;
    float angle;
    public float timer;
    //public static int Mblood = 4;
    // Start is called before the first frame update
    void Start()
    {
        AnimatorRobot = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorRobot.SetBool("Idle", Idle);
        AnimatorRobot.SetBool("walk", walk);
        AnimatorRobot.SetBool("attack", attack);




        angle = Vector3.Angle(transform.forward, player.position - transform.position);

        Vector3 v = Vector3.Cross(transform.forward, player.position - transform.position);
        if (v.y > 0)
        {
             transform.Rotate(Vector3.up * angle);
        }
        else 
        {
             transform.Rotate(Vector3.down * angle);
        }
        if(walk)
        {
             transform.Translate(0, 0, 0.07f);        
        }
        if(attack)
        {
            timer+= Time.deltaTime;
            if (timer >= 0.7)
            {
                pro_blood.proBlood -= 1 ;
                timer = 0;
            }
        }
        
        
    }
}
