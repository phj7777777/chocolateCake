using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weight : MonoBehaviour {
    public Text display;
    public GameObject continueButton;
    public AudioSource sound;
    public AudioSource success;
	// Use this for initialization
	void Start () {
        continueButton.SetActive(false);
	}

    void Update() {
        GameObject butterTick = GameObject.Find("butterCross");
        GameObject selfTick = GameObject.Find("selfCross");
        GameObject sugarTick = GameObject.Find("sugarCross");
        GameObject choTick = GameObject.Find("choCross");
        GameObject cocoaTick = GameObject.Find("cocoaCross");
        GameObject milkTick = GameObject.Find("milkCross");
        GameObject flourTick = GameObject.Find("plainCross");
        if (!butterTick && !selfTick && !milkTick && !choTick && !cocoaTick && !flourTick && !sugarTick)
        {
            continueButton.SetActive(true);
            success.Play();
        }
    
    }




    void OnCollisionEnter(Collision col)
    {
        Debug.Log(gameObject.name + "has collide with" + col.gameObject.name);
        col.gameObject.SetActive(false);
        sound.Play();
        if (col.gameObject.name == "butter") {
            display.text = "200g";
            Destroy(GameObject.Find("butterCross").gameObject);
        }
        else if (col.gameObject.name == "selfObj")
        {
            Destroy(GameObject.Find("selfCross").gameObject);
            display.text = "85g";
        }
        else if (col.gameObject.name == "sugarObj")
        {
            Destroy(GameObject.Find("sugarCross").gameObject);
            display.text = "200g";
        } 
        else  if (col.gameObject.name == "cocoaObj")
        {
            Destroy(GameObject.Find("cocoaCross").gameObject);
            display.text = "25g";
        }
        else if (col.gameObject.name == "milk")
        {
            Destroy(GameObject.Find("milkCross").gameObject);
            display.text = "75g";
        }
        else if (col.gameObject.name == "chocolate")
        {
            Destroy(GameObject.Find("choCross").gameObject);
            display.text = "200g";
        }
        else if (col.gameObject.name == "flourObj")
        {
            Destroy(GameObject.Find("plainCross").gameObject);
            display.text = "85g";
        }



    }
}
