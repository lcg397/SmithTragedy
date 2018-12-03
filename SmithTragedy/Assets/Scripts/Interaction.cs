using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject fpsCon;
    public Transform currentPosition;
    public Quaternion currentRotation;
    public Quaternion cameraRotation;
    public LayerMask evidenceLayer = 9;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InteractCast();
    }

    void InteractCast()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 16f))
        {
            Debug.Log(hit.transform.gameObject.name.ToString());
            if(Input.GetKeyDown(KeyCode.Mouse0) && hit.transform.gameObject.tag == "Evidence")
            {
                  

                  GetComponent<Inventory>().newEvidence = hit.transform.gameObject;
                  fpsCon.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().canMove = false;
                  GetComponent<Inventory>().PullIn();
                GetComponent<Inventory>().isViewing = true;

            }
            

        }
    }
    public void ResetCharacterPosRot()
    {

        fpsCon.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().canMove = true;
        GetComponent<Inventory>().newEvidence = null;
    }
    
}
