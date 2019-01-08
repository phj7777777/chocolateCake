using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour {

    public GameObject text;

    void Start(){
        text.SetActive(false);
    
    }

    public void gogogo()
    {
        text.SetActive(true);

    }
}
