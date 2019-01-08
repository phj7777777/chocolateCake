using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour {

    public AudioSource sound;
    float distance = 1;

    void OnMouseDrag() {
        if (GameObject.Find("buttonLow") == null)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;
            sound.Play();
        }
        
    
    }

}
