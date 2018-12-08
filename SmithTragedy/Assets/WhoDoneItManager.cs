using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhoDoneItManager : MonoBehaviour {

    public bool right, wrong, open, foundAll;
    public List<GameObject> UI;
    public GameObject who, con, go1,go2,go3,go4, wrongGo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (foundAll)
        {
      
            if (!open)
            {
                if (Input.GetKeyDown(KeyCode.P))
                {
                    SceneManager.LoadScene("EndMenu");
                }
            }
        }


	}

    public void GotRight()
    {
        wrong = false;
        right = true;
        go1.SetActive(false);
        go2.SetActive(true);


    }
    public void GotWrong()
    {
        
        right = false;
        wrong = true;
        go1.SetActive(false);

        go2.SetActive(false);
        go3.SetActive(false);
        wrongGo.SetActive(true);




    }

    public void next2()
    {
        if (!wrong)
        {
            go1.SetActive(false);
            go2.SetActive(false);
            go3.SetActive(true);
        }
        


    }
    public void next3()
    {
        if (!wrong)
        {
            go1.SetActive(false);
            go2.SetActive(false);
            go3.SetActive(false);
            go4.SetActive(true);
        }
        

    }
}
