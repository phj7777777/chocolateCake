using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickOven : MonoBehaviour {
    public GameObject target;
    public GameObject empty;
    public GameObject resetButton;
    public GameObject cross;
    public AudioSource success;
    public AudioSource click;
    public Text heat;
    int count;
    int countTime;
    bool cont,isSuccess,firstHeat,firstTime;
    void Start()
    {
        count = 0;
        countTime = 0;
        cont = true;
        isSuccess = false;
        firstHeat = true;
        firstTime = true;


    }
    void Update() {
        if (GameObject.Find("bCross") == null)
        {
            isSuccess = true;

        }
        if (GameObject.Find("cCross") == null && GameObject.Find("eCross") == null)
        {
            empty.SetActive(true);
        }
    
    }

    void OnMouseDown()
    {

        if (isSuccess) {

            if (GameObject.Find("reset") == null)
            {
                count = 0;
                cont = true;
                cross.SetActive(true);
            }
            if (GameObject.Find("resetTime") == null)
            {
                
                countTime = 0;
                cont = true;
                cross.SetActive(true);
            }

            target.SetActive(true);

            if (cont)
            {
                if (gameObject.name == "timeUp")
                {
                    countTime+=3;
                    heat.text = countTime + "min";

                }
                else
                {
                    count += 20;
                    heat.text = count + "c";
                }
                gameObject.SetActive(false);
                Invoke("appear", 0.5f);
            }



            if (count == 160)
            {
                cont = false;
                resetButton.SetActive(false);
                cross.SetActive(false);
                if (firstHeat) {
                    firstHeat = false;
                    success.Play();
                }
                
            }
            if (countTime == 15)
            {
                cont = false;
                resetButton.SetActive(false);
                cross.SetActive(false);
                if (firstTime) {
                    firstTime = false;
                    success.Play();
                }
               
            }
        
        
        }

      
    }

    void appear()
    {

        gameObject.SetActive(true);
        
        click.Play();
       



    }





}
