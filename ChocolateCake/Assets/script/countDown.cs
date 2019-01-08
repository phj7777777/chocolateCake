using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDown : MonoBehaviour {
    public int timeLeft = 5;
    public Text countdownText;
    public GameObject smoke;
    public GameObject next;
    public AudioSource sound;
    bool success;
	// Use this for initialization
    void Awake()
    {
        success = false;


    }
	
	// Update is called once per frame
	void Update () {

        GameObject heatDown = GameObject.Find("heatDown");
        GameObject timeDown = GameObject.Find("timeDon");
        if (!heatDown && !timeDown && !success)
        {
            Debug.Log("wtf");
            StartCoroutine("LoseTime");
            success = true;
        }

        if (success)
        {
            //nextButton.SetActive(true);


            if (timeLeft <= 0)
            {
                StopCoroutine("LoseTime");
                sound.Stop();
                smoke.SetActive(true);
                Invoke("display", 3f);
            }
        }
        
	}

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            countdownText.text = (timeLeft + "min");
            sound.Play();
        }
    }


    void display() {
        next.SetActive(true);
    }
}
