using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upButton : MonoBehaviour {
    public AudioSource sound;

    void OnMouseDown()
    {
        sound.Play();
    }
    
}
