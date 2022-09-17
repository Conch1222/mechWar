using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProAnim : MonoBehaviour
{
    Animator AnimatorPro;
    public bool BoolRun, BoolWalkBack, BoolWalkLeft, BoolWalkRight;
    public bool BoolJump, BoolShoot, BoolDie;

    // Start is called before the first frame update
    void Start()
    {
        AnimatorPro = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorPro.SetBool("BoolRun", BoolRun);
        AnimatorPro.SetBool("BoolWalkBack", BoolWalkBack);
        AnimatorPro.SetBool("BoolWalkLeft", BoolWalkLeft);
        AnimatorPro.SetBool("BoolWalkRight", BoolWalkRight);
        AnimatorPro.SetBool("BoolJump", BoolJump);
        AnimatorPro.SetBool("BoolShoot", BoolShoot);
        AnimatorPro.SetBool("BoolDie", BoolDie);
    }
}
