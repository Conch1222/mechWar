using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProControl : MonoBehaviour
{
    public bool OnFloor = true;
    public float MoveDistancd, JumpHigh;
    public GameObject Robot0, Robot1, Robot2, Robot3, Robot4, Robot5;
    public GameObject diamond;
    public float x, y;
    public float xSpeed, ySpeed;
    void Start()
    {

    }

    void Update()
    {

        decideMove();
        decideJump();
        decideShoot();
        LateUpdate();

    }



    void decideMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<ProAnim>().BoolRun = true;
            transform.Translate(0, 0, MoveDistancd);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            GetComponent<ProAnim>().BoolRun = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<ProAnim>().BoolWalkBack = true;
            transform.Translate(0, 0, -MoveDistancd * 0.75f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            GetComponent<ProAnim>().BoolWalkBack = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<ProAnim>().BoolWalkLeft = true;
            transform.Translate(-MoveDistancd * 0.75f, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<ProAnim>().BoolWalkLeft = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<ProAnim>().BoolWalkRight = true;
            transform.Translate(MoveDistancd * 0.75f, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<ProAnim>().BoolWalkRight = false;
        }
    }

    void decideJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnFloor == true)
        {
            GetComponent<ProAnim>().BoolJump = true;
            GetComponent<Rigidbody>().AddForce(0, JumpHigh, 0);
            OnFloor = false;
        }
    }

    void decideShoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<ProAnim>().BoolShoot = true;
            BulletControl.isAttack = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            GetComponent<ProAnim>().BoolShoot = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "map")
        {
            GetComponent<ProAnim>().BoolJump = false;
            OnFloor = true;
        }
    }

    void OnTriggerEnter(Collider CollisionDetection)
    {
        if (CollisionDetection.tag == "Diamond")
        {
            Robot0.SetActive(true);
            Destroy(diamond);
        }

        if (CollisionDetection.tag == "range")
        {
            Robot1.GetComponent<robot_ani>().walk = true;
        }
        if (CollisionDetection.tag == "attack")
        {
            Robot1.GetComponent<robot_ani>().walk = false;
            Robot1.GetComponent<robot_ani>().attack = true;
        }

        if (CollisionDetection.tag == "range02")
        {
            Robot2.GetComponent<robot_ani>().walk = true;
        }
        if (CollisionDetection.tag == "attack02")
        {
            Robot2.GetComponent<robot_ani>().walk = false;
            Robot2.GetComponent<robot_ani>().attack = true;
        }

        if (CollisionDetection.tag == "range00")
        {
            Robot0.GetComponent<robot_ani>().walk = true;
        }
        if (CollisionDetection.tag == "attack00")
        {
            Robot0.GetComponent<robot_ani>().walk = false;
            Robot0.GetComponent<robot_ani>().attack = true;
        }

        if (CollisionDetection.tag == "range03")
        {
            Robot3.GetComponent<robot_ani>().walk = true;
        }
        if (CollisionDetection.tag == "attack03")
        {
            Robot3.GetComponent<robot_ani>().walk = false;
            Robot3.GetComponent<robot_ani>().attack = true;
        }

        if (CollisionDetection.tag == "range04")
        {
            Robot4.GetComponent<robot_ani>().walk = true;
        }
        if (CollisionDetection.tag == "attack04")
        {
            Robot4.GetComponent<robot_ani>().walk = false;
            Robot4.GetComponent<robot_ani>().attack = true;
        }

        if (CollisionDetection.tag == "range05")
        {
            Robot5.GetComponent<robot_ani>().walk = true;
        }
        if (CollisionDetection.tag == "attack05")
        {
            Robot5.GetComponent<robot_ani>().walk = false;
            Robot5.GetComponent<robot_ani>().attack = true;
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

        if (CollisionDetection.tag == "range02")
        {
            Robot2.GetComponent<robot_ani>().walk = false;
        }
        if (CollisionDetection.tag == "attack02")
        {
            Robot2.GetComponent<robot_ani>().walk = true;
            Robot2.GetComponent<robot_ani>().attack = false;
        }

        if (CollisionDetection.tag == "range00")
        {
            Robot0.GetComponent<robot_ani>().walk = false;
        }
        if (CollisionDetection.tag == "attack00")
        {
            Robot0.GetComponent<robot_ani>().walk = true;
            Robot0.GetComponent<robot_ani>().attack = false;
        }

        if (CollisionDetection.tag == "range03")
        {
            Robot3.GetComponent<robot_ani>().walk = false;
        }
        if (CollisionDetection.tag == "attack03")
        {
            Robot3.GetComponent<robot_ani>().walk = true;
            Robot3.GetComponent<robot_ani>().attack = false;
        }

        if (CollisionDetection.tag == "range04")
        {
            Robot4.GetComponent<robot_ani>().walk = false;
        }
        if (CollisionDetection.tag == "attack04")
        {
            Robot4.GetComponent<robot_ani>().walk = true;
            Robot4.GetComponent<robot_ani>().attack = false;
        }

        if (CollisionDetection.tag == "range05")
        {
            Robot5.GetComponent<robot_ani>().walk = false;
        }
        if (CollisionDetection.tag == "attack05")
        {
            Robot5.GetComponent<robot_ani>().walk = true;
            Robot5.GetComponent<robot_ani>().attack = false;
        }
    }

    void LateUpdate()
    {
        x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;

        if (x > 360)
        {
            x -= 360;
        }
        else if (x < 0)
        {
            x += 360;
        }
        transform.rotation = Quaternion.Euler(y, x, 0);
    }
}
