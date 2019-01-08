using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableGameObject : MonoBehaviour {

   
    public void enable( GameObject x) {
        x.SetActive(false);
    }
}
