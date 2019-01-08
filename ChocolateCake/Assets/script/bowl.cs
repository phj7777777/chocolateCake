using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowl : MonoBehaviour {

    public GameObject pan;
    public GameObject bowler;
    public GameObject spoon;
    public GameObject bag;

	// Use this for initialization
	void Start () {
        pan.SetActive(false);
        bowler.SetActive(false);
        bag.SetActive(false);
        spoon.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
