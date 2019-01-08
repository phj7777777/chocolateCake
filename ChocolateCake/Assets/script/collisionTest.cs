using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionTest : MonoBehaviour
{
    public Rigidbody SheepRB; //The sheep rigidbody

    void Start() {
        SheepRB = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        
        SheepRB.isKinematic = true; //Turns off the Kinematic
        
    }
    void OnCollisionExit(Collision col)
    {
        SheepRB.isKinematic = false; //Turns off the Kinematic
        
    }

   
}
