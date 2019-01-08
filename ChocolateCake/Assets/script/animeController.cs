using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animeController : MonoBehaviour {

    public Animator anim;
    public string animation;
    public Animator drop;
    public string dropAnimation;
    public Animator milkDrop;
    public string milkDropAnimation;
    public Animator left;
    public string leftAnimation;
    public Animator right;
    public string rightAnimation;
    public GameObject little;
    public GameObject middle;
    public GameObject lot;
    public GameObject lotlot;
    public AudioSource egg;
    public AudioSource success;
    public GameObject dropGO;
    public GameObject milkGO;
    public GameObject leftGO;
    public GameObject rightGO;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
       
	}
	


    void OnMouseDown()
    {
        anim.Play(animation);
        
        Invoke("eggSound", 1.1f);
        if (gameObject.name == "bardak"){
        
            Invoke("milkDisappear", 1.2f);
            Invoke("disappear", 2.5f);
            Invoke("bardak", 2.5f);
            
        }
        else {
            Invoke("eggDisappear", 2f);
            Invoke("disappear", 2.5f);
        }
       
    }

    void eggDisappear() {
        gameObject.SetActive(false);
        dropGO.SetActive(true);
        leftGO.SetActive(true);
        rightGO.SetActive(true);
        drop.Play(dropAnimation);
        left.Play(leftAnimation);
        right.Play(rightAnimation);
    }
    void milkDisappear()
    {
        GameObject bcross = GameObject.Find("bCross");
        milkGO.SetActive(true);
        milkDrop.Play(milkDropAnimation);
        bcross.SetActive(false);
        success.Play();
       
     
        
    }
    void bardak()
    {
        gameObject.SetActive(false);
    }
    void disappear() {
        milkGO.SetActive(false);
        dropGO.SetActive(false);
        leftGO.SetActive(false);
        rightGO.SetActive(false);
        GameObject butterTick = GameObject.Find("egg");
        GameObject eggTick = GameObject.Find("eggA");
        GameObject milkTick = GameObject.Find("eggB");
        GameObject choTick = GameObject.Find("bardak");
        GameObject across = GameObject.Find("aCross");
        
    
            if (!butterTick && !eggTick && !milkTick)
            {
                if (across) {
                    across.SetActive(false);
                    success.Play();
                }
                
                

           }

           

        if (GameObject.Find("little") == null)
        {
            little.SetActive(true);

        }
        else if (GameObject.Find("middle") == null)
        {
           middle.SetActive(true);

        }
        else if (GameObject.Find("lot") == null)
        {
            lot.SetActive(true);

        }
        else if (GameObject.Find("lotlot") == null)
        {
            lotlot.SetActive(true);

        }
 
    }

    void eggSound() {

       
        egg.Play();

    }
}
