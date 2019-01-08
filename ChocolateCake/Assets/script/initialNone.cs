using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialNone : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}


    void Update() {
        GameObject butterTick = GameObject.Find("sugarObj");
        if (!butterTick) gameObject.SetActive(true);
    }
}
