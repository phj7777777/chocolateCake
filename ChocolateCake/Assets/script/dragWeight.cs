using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragWeight : MonoBehaviour
{
    public AudioSource sound;
    public float distance = 4;

    void OnMouseDrag()
    {
        
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;
            sound.Play();
            
        

    }

}
