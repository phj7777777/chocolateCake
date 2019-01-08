using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKIP : MonoBehaviour {

   public  void skipppp() {
        if (BGSoundScript.Instance.gameObject != null)
        {
            BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();﻿
        }//end of yiruma song
    
    
    }
}
