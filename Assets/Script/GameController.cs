using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject ScoreUI, TopLeftUI;
    public GameObject ScoreText, LifeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(robot_blood.Mblood[2] == 0 || pro_blood.proBlood ==0)
        { 
            ScoreText.GetComponent<Text>().text = "" + star_cnt.countStar;
            LifeText.GetComponent<Text>().text = "" + pro_blood.proBlood;
            ScoreUI.SetActive(true);
            TopLeftUI.SetActive(false);
        }
        
    }
}
