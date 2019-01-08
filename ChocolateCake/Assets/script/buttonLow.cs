using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonLow : MonoBehaviour {

    public AudioSource fire;
    public AudioSource stove;
    public ParticleSystem particles;
    public GameObject drag;
    void OnMouseDown()
    {
        drag.SetActive(true);
        Destroy(gameObject); //delete
        Destroy(GameObject.Find("cCross").gameObject);
        stove.Play();
        particles.Play();
        fire.PlayDelayed(2);
    }

   
   


}
