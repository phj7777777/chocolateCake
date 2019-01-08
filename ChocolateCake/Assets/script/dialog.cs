using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class dialog : MonoBehaviour {

    public TextMeshProUGUI textDisplayer;
    public string[] sentences;
    private int index;
    public GameObject nextButton;
 
    void Start() {
        StartCoroutine(Type());
    }
    IEnumerator Type() {
        foreach (char letter in sentences[index].ToCharArray()) {
            textDisplayer.text += letter;
            yield return new WaitForSeconds(0.02f);
        
        }
    
    }

    void Update()
    {
        if (textDisplayer.text == sentences[index]) {
            nextButton.SetActive(true);
        }

    }

    public void NextSentence(string scenename) {
        nextButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplayer.text = "";
            StartCoroutine(Type());
        }
        else {
            nextButton.SetActive(true);
            if (BGSoundScript.Instance.gameObject != null)
            {
                BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();﻿
        }//end of yiruma song
            Application.LoadLevel(scenename);

        }
    }
}
