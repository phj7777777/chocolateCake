using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    public string name;
    public string x;
    public AudioSource sound;

    void OnMouseDown()
    {
        
        Destroy(gameObject); //delete
        sound.Play();

        if (gameObject.name == "butter")
        {
            name = "butterCross";
                 
        }
        else if (gameObject.name == "milk") {
            name = "milkCross";
               
        }
        else if (gameObject.name == "eggGroup") { 
            name = "eggCross";
            
        }
        else if (gameObject.name == "flourObj")
        {
            name = "flourCross";

        }
        else if (gameObject.name == "sodaObj")
        {
            name = "sodaCross";

        }
        else if (gameObject.name == "cocoaObj")
        {
            name = "cocoaCross";

        }
        else if (gameObject.name == "sugarObj")
        {
            name = "sugarCross";

        }
        else if (gameObject.name == "selfObj")
        {
            name = "selfCross";

        }
        else if (gameObject.name == "chocolate")
        {
            name = "choCross";

        }
        
        

        Debug.Log(gameObject.name);

        GameObject go = GameObject.Find (name);
        if (go){ Destroy (go.gameObject);}
        
    }
}
