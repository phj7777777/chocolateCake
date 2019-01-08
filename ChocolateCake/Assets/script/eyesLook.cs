using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyesLook : MonoBehaviour {


    private Vector2 mouseDirection; //mouseDirection
    private Transform myBody; //capsuleParent



	// Use this for initialization
	void Start () {
        myBody = this.transform.parent.transform;
	}
	
	// Update is called once per frame
	void Update () {
        //detect how much mouse move
		Vector2 mc = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mouseDirection += mc;
        //change angle
        this.transform.localRotation = Quaternion.AngleAxis(-mouseDirection.y, Vector3.right);
        myBody.localRotation = Quaternion.AngleAxis(mouseDirection.x, Vector3.up);
    
    }
}
