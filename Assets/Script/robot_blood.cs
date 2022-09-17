using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_blood : MonoBehaviour
{
    public int countDie = 0;
    public static int[] Mblood = new int[6];
    public GameObject[] Monster = new GameObject[6];
    public GameObject Diamond;
    public bool first = true;

    // Start is called before the first frame update
    void Start()
    {
        //for(int i=0;i<2;i++)
        //{
        Mblood[0] = 5;
        Mblood[1] = 5;
        Mblood[2] = 20;
        Mblood[3] = 5;
        Mblood[4] = 5;
        Mblood[5] = 5;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 6; i++)
        {
            if (Mblood[i] == 0)
            {
                Destroy(Monster[i]);
                countDie++;
                Mblood[i] = -1;
            }
        }

        if(countDie == 5 && first)
        {
            Diamond.SetActive(true);
            first = false;
        }
    }
}
