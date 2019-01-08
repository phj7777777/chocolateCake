using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateBowl : MonoBehaviour {

    public Animator anim;
    public string animation;
    public GameObject little;
    public GameObject text;
    public AudioSource bowl;
    public AudioSource success;
    public GameObject nextButton;
    void Start()
    {
        anim = GetComponent<Animator>();
        little.SetActive(false);

    }

    void OnMouseDown()
    {
        text.SetActive(false);
        anim.Play(animation);

        Invoke("bowlSound", 1.1f);

        Invoke("disappear", 1.5f);
    }

    void disappear()
    {

        gameObject.SetActive(false);
        GameObject across = GameObject.Find("aCross");
        across.SetActive(false);
        success.Play();
        little.SetActive(true);
        nextButton.SetActive(true);



     }

       


    void bowlSound()
    {
        bowl.Play();
    }
}
