using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextButton : MonoBehaviour
{
   
    public GameObject continueButton;

    void Start()
    {
        continueButton.SetActive(false);
    }

    void Update() {

        GameObject butterTick = GameObject.Find("butterCross");
        GameObject eggTick = GameObject.Find("eggCross");
        GameObject milkTick = GameObject.Find("milkCross");
        GameObject choTick = GameObject.Find("choCross");
        if (!butterTick && !eggTick && !milkTick && !choTick)
        {
            continueButton.SetActive(true);
        }
    }


}
