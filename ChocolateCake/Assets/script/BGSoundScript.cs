using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BGSoundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    //Play Global
    private static BGSoundScript instance = null;
    public static BGSoundScript Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        
        DontDestroyOnLoad(this.gameObject);
    }
    //Play Gobal End



    // Update is called once per frame
    void Update () {
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "introScene" || sceneName == "startScene")
        {
            Destroy(this.gameObject);
        }
	}
}
