using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour {
    public enum CurrentScene
    {
        InteractTest,
        HouseTest



    }
    public CurrentScene whichCurrentScene;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(whichCurrentScene.ToString());



        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(0);




        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene(1);




        }
    }
}
