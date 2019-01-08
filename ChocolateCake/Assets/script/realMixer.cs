using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realMixer : MonoBehaviour {
    public Animator anim;
    public AudioSource sound;
    public AudioSource success;
    public GameObject mixerCanvas;
    public GameObject cCross;
    public GameObject nextButton;
    void start() {
        anim = GetComponent<Animator>();
        
    }
    void OnMouseDown()
    {
        
        mixerCanvas.SetActive(false);
        anim.Play("hand");
        sound.Play();
        success.Play();
        cCross.SetActive(false);
        Invoke("appear", 2.5f);
    }

    void appear() {
        nextButton.SetActive(true);
        success.Play();
    }
}
