using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlDestroy : MonoBehaviour {

    public GameObject target;
    public GameObject product;
    public AudioSource sound;
    // Use this for initialization
    void Start()
    {
        target.SetActive(false);
       
    }


    void OnMouseDown()
    {
        product.SetActive(true);
        target.SetActive(true);
        sound.Play();
        gameObject.SetActive(false);
        Invoke("disappear", 1.2f);
    }

    void disappear() {
        product.SetActive(false);
        target.SetActive(false);
      
    }

}
