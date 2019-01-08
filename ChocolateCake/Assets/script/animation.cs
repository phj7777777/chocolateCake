using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour {

    public Animator anim;
    public string animati;
    public GameObject granules;
    public GameObject aCross;
    public GameObject bCross;
    public GameObject button;
    public AudioSource powder;

    //public GameObject nextButton;
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    void OnMouseDown()
    {
        anim.Play(animati);
       
        Invoke("powderSound", 1.2f);
        Invoke("disappear", 1.5f);
        Invoke("show", 2.5f);

    }

    void disappear()
    {
        gameObject.SetActive(false);
    }

    void powderSound()
    {
      
        granules.SetActive(true);
        powder.Play();
    }

    void show() {
      
        aCross.SetActive(false);
        bCross.SetActive(false);
        button.SetActive(true);
       

    }
}
