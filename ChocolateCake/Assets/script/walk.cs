using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
        float movement = Input.GetAxis("Vertical");
        float movementL = Input.GetAxis("Horizontal");
        movement *= (Time.deltaTime * 10f); //follow how much system run
        movementL *= (Time.deltaTime * 10f); //follow how much system run
        this.transform.Translate(Vector3.forward * movement);
        this.transform.Translate(Vector3.left * -movementL);
    }
}
