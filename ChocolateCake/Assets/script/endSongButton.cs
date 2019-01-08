using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endSongButton : MonoBehaviour {
    public AudioSource button;
    public void changeScene(string scenename)
    {
        button.Play();
       
        
        StartCoroutine(MyFunction(scenename, 0.2f));

    }

    IEnumerator MyFunction(string scenename, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        // Now do your thing here
        Application.LoadLevel(scenename);
    }

}
