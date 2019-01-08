using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class deleteOven : MonoBehaviour {
    public GameObject target;

    public AudioSource success;

    public Text heat;
    bool cont, isSuccess;

    void Start() { 
        isSuccess = false;
    
    }

    void Update()
    {
        if (GameObject.Find("bCross") == null)
        {
            isSuccess = true;
        }

    }


    void OnMouseDown()
    {
        if (isSuccess) {
            target.SetActive(false);
            gameObject.SetActive(false);
            Invoke("appear", 0.5f);
            
            if (gameObject.name == "timeDon")
            {
                
                heat.text =   "0min";

            }
            else
            {
                
                heat.text = "0c";
            }
        }
        
    }

    void appear()
    {

        gameObject.SetActive(true);

        success.Play();




    }
}
