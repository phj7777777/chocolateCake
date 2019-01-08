using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chocolate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
  
   void Update(){
       if (GameObject.Find("chocolate") == null && GameObject.Find("cho") == null && GameObject.Find("butter") == null)
       {
           gameObject.SetActive(true);
           
       }
   
   
   }
       
      
    
}
