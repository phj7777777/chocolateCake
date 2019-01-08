using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearStart : MonoBehaviour {
    public GameObject mainCamera;
    void Start()
    {
        gameObject.SetActive(false);
       
    }


    void Update()
    {
      if (mainCamera.GetComponent<Camera>().enabled == false) {
            transform.GetChild(0).gameObject.SetActive(false);
            
        }
    }
}
