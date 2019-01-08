using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlMixer : MonoBehaviour
{
    public GameObject mix;
    public AudioSource sound;
    public GameObject aCross;
    // Use this for initialization
    void Start()
    {
       
        mix.SetActive(false);
    
    }


    void OnMouseDown()
    {
        GameObject butterTick = GameObject.Find("eggBowl");
        GameObject eggTick = GameObject.Find("pan");
        GameObject milkTick = GameObject.Find("sodaObj");
        GameObject choTick = GameObject.Find("sugarObj");
        GameObject a = GameObject.Find("cocoaObj");
        GameObject b = GameObject.Find("selfObj");
        GameObject c = GameObject.Find("flourObj");


        if (!butterTick && !eggTick && !milkTick && !choTick && !a && !b && !c)
        {

            sound.Play();
            aCross.SetActive(false);
            mix.SetActive(true);
            gameObject.SetActive(false);



        }

    }


}
