using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bgSong : MonoBehaviour {
    // Use this for initialization
    void Start()
    {

    }

    //Play Global
    private static bgSong i = null;
    public static bgSong I
    {
        get { return i; }
    }

    void Awake()
    {
        if (i != null && i != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            i = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    //Play Gobal End

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "storyEndScene" )
        {
            Destroy(this.gameObject);
        }

    }
}
