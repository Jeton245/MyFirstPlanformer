using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class UiGod : MonoBehaviour
{
    public Button pray;
    public Button goAway;
    public GameObject gods;
    public PlayerCombat playerCombat;
    public GameObject tableGod;
    public bool godOn = false;
   
    private void Start()
    {
        Button prayButton = pray.GetComponent<Button>();
        prayButton.onClick.AddListener(TaskOnClick);
        Button goAwayButton = goAway.GetComponent<Button>();
        goAwayButton.onClick.AddListener(TaskOnClickEnd);
    }
    void TaskOnClick()
    {
        playerCombat.Damage += 100;
        gods.SetActive(false);
        tableGod.GetComponent<BoxCollider2D>().enabled=false;
        godOn = true;



    }
    void TaskOnClickEnd()
    {
        Debug.Log("Disappointed");
        gods.SetActive(false);
    }


}
