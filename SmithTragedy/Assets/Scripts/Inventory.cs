using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Camera playerCamera;
    public List<GameObject> evidencePrefabs;
    
    public GameObject newEvidence;
    public GameObject inventoryUI;
    public Text evidenceDescription;
    public bool murderWeapon, letter, brochure, laptop, robPhone, rileyPhone, mattPhone, poison, safeFlier;
    public bool isViewing;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(isViewing == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (newEvidence.name == "Stake")
                {
                    Destroy(newEvidence);
                    murderWeapon = true;
                    PullOut();

                }
                else if (newEvidence.name == "Letter")
                {
                    Destroy(newEvidence);
                    letter = true;
                    PullOut();
                }
                else if (newEvidence.name == "Brochure")
                {
                    Destroy(newEvidence);
                    brochure = true;
                    PullOut();
                }
                else if (newEvidence.name == "Laptop")
                {
                    Destroy(newEvidence);
                    laptop = true;
                    PullOut();
                }
                else if (newEvidence.name == "Poison")
                {
                    Destroy(newEvidence);
                    poison = true;
                    PullOut();
                }
                else if (newEvidence.name == "RobPhone")
                {
                    Destroy(newEvidence);
                    robPhone = true;
                    PullOut();
                }
                else if (newEvidence.name == "RileyPhone")
                {
                    Destroy(newEvidence);
                    rileyPhone = true;
                    PullOut();
                }
                else if (newEvidence.name == "MattPhone")
                {
                    Destroy(newEvidence);
                    mattPhone = true;
                    PullOut();
                }
                else if (newEvidence.name == "SafeFlier")
                {
                    Destroy(newEvidence);
                    safeFlier = true;
                    PullOut();
                }




            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                PullOut();


            }


        }
    }
    public void PullOut()
    {
        isViewing = false;
        playerCamera.fieldOfView = 60f;
        GetComponent<Interaction>().ResetCharacterPosRot();
        inventoryUI.SetActive(false);



    }
    public void PullIn()
    {
        playerCamera.transform.LookAt(newEvidence.transform);
        inventoryUI.SetActive(true);
        evidenceDescription.text = newEvidence.GetComponent<EvidenceDescription>().evidenceDes;
        playerCamera.fieldOfView = 20f;
        
    }
}
