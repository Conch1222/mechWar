using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pro_blood : MonoBehaviour
{
    public static int proBlood = 10;
    public Text bloodNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bloodNum.text = proBlood.ToString();
    }
}
