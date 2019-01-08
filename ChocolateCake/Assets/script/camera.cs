using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{

    public AudioSource success;
    GameObject mainCamera;
    GameObject secondCamera;
    public GameObject item;
    bool isSecondary;
    bool isSuccess;
    // Use this for initialization
    void Start()
    {

        isSuccess = false;
        isSecondary = false;
        mainCamera = GameObject.FindWithTag("MainCamera");
        secondCamera = GameObject.FindWithTag("SecondCamera");

    }


    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("switchOn") == null)
        {
            isSuccess = true;
        }
    }

    void OnMouseDown()
    {
        if (isSecondary == false)
        {
            isSecondary = true;
        }
        if (isSuccess)
        {
            gameObject.SetActive(false);
            if (GameObject.Find("bCross"))
            {
                Destroy(GameObject.Find("bCross").gameObject);
                success.Play();
            }

            if (isSecondary)
            {
                mainCamera.GetComponent<Camera>().enabled = false;
                secondCamera.GetComponent<Camera>().enabled = true;

            }
            else
            {
                secondCamera.GetComponent<Camera>().enabled = false;
                mainCamera.GetComponent<Camera>().enabled = true;
            }



        }

    }
}


