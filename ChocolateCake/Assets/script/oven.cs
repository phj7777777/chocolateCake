using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oven : MonoBehaviour {

    public string name;
    public GameObject x;
    public AudioSource success;

    public AudioSource ovenSound;


    void OnMouseDown()
    {

        Destroy(gameObject); //delete

        
        if (gameObject.name == "switchOn")
        {          
            name = "switchOnCanvas";
            Destroy(GameObject.Find("aCross").gameObject);
            x.SetActive(true);
            ovenSound.Play();
            success.Play();
        }



        GameObject go = GameObject.Find(name);
        if (go) { Destroy(go.gameObject); }
    }

}
