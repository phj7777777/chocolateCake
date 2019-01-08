using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextCupboard : MonoBehaviour
{
   
    public GameObject Button;

    void Start()
    {
        Button.SetActive(false);
    }

    void Update()
    {
        GameObject butterTick = GameObject.Find("flourCross");
        GameObject eggTick = GameObject.Find("sodaCross");
        GameObject milkTick = GameObject.Find("sugarCross");
        GameObject selfTick = GameObject.Find("selfCross");
        GameObject cocoaTick = GameObject.Find("cocoaCross");
        if (!butterTick && !eggTick && !milkTick && !selfTick && !cocoaTick)
        {
            
            Button.SetActive(true);
          
        }
    }


}
