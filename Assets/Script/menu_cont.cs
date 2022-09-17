using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menu_cont : MonoBehaviour
{
    public GameObject MenuScoreText;

    void Start()
    {

    }

    void Update()
    {

    }

    public void MenuStartButton()
    {
        Application.LoadLevel("MainScene");
    }

    public void MenugameretButton()
    {
        pro_blood.proBlood = 10;
        star_cnt.countStar = 0;
        robot_blood.Mblood[0] = 4;
        robot_blood.Mblood[1] = 4;
        robot_blood.Mblood[2] = 20;
        robot_blood.Mblood[3] = 4;
        robot_blood.Mblood[4] = 4;
        robot_blood.Mblood[5] = 4;
        Application.LoadLevel("Menu");
    }

    public void MenuRulesButton()
    {
        Application.LoadLevel("Rules");
    }
    public void MenuReturnButton()
    {
        Application.LoadLevel("Menu");
    }
    public void MenuExitButton()
    {
        Application.Quit();
    }

    
}