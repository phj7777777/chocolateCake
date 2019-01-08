using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pan : MonoBehaviour
{
    public AudioSource sound;
    public GameObject respawn;
    public GameObject drag;
    public GameObject uncle;
    public GameObject mixer;
    public GameObject nextButton;
    public ParticleSystem particles;
    void Start() {
        
        nextButton.SetActive(false);
    }



    public void Sh()
    {
        particles.Play();
        respawn.SetActive(true);
      
        Invoke("displayButton", 3.0f);
    }

    public void displayButton()
    {
        sound.Play();
        nextButton.SetActive(true);
        Destroy(GameObject.Find("aCross").gameObject);

    }
    void OnCollisionEnter(Collision col)
    {

        col.gameObject.SetActive(false);
        if (GameObject.Find("chocolate") == null && GameObject.Find("cho") == null&&GameObject.Find("butter") == null )
        {
            sound.Play();
            drag.SetActive(false);
            Destroy(GameObject.Find("bCross").gameObject);
            mixer.SetActive(true);
            uncle.SetActive(true);
            Invoke("Sh", 2.0f);
           

        }
    }

   
}
