using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mixer : MonoBehaviour {
    public GameObject mix;
    bool success;
	// Use this for initialization
	void Start () {
        mix.SetActive(false);
        success = false;
	}


    void OnMouseDown()
    {
        GameObject butterTick = GameObject.Find("egg");
        GameObject eggTick = GameObject.Find("eggA");
        GameObject milkTick = GameObject.Find("eggB");
        GameObject choTick = GameObject.Find("bardak");

        if (!butterTick && !eggTick && !milkTick &&!choTick)
        {
            
                mix.SetActive(true);
                gameObject.SetActive(false);
            
            

        }
    
    }


}
