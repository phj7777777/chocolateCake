using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collide : MonoBehaviour {
    public GameObject text;
    public GameObject hint;
    public string scene;
    bool success;
	// Use this for initialization
	void Start () {
        text.SetActive(false);
        hint.SetActive(true);
        success = false;
	}

    void Update()
    {

        if (success&&Input.GetKeyUp(KeyCode.E)) SceneManager.LoadScene(scene);
    }

	// Update is called once per frame
	void OnTriggerEnter(Collider player) {
                
            text.SetActive(true);
            success = true;
           
	}

    void OnTriggerExit(Collider player)
    {
        
        
            text.SetActive(false);
             
        

    }


}
