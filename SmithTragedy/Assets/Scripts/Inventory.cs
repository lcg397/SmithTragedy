using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Camera playerCamera;
    public List<GameObject> evidencePrefabs;
    DialogueManager DM;
    public GameObject newEvidence;
    public GameObject inventoryUI;

    public Text evidenceDescription, examineText;
    public bool murderWeapon, letter, brochure, laptop, robPhone, rileyPhone, mattPhone, poison, safeFlier;
    public bool isViewing, dialogueTriggered;
    
    // Start is called before the first frame update
    void Start()
    {
        DM = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
     if(isViewing == true && dialogueTriggered == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                examineText.text = "E: Next";
                if (newEvidence.name == "Stake")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    murderWeapon = true;
                    //PullOut();

                }
                if (newEvidence.name == "Letter")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    letter = true;
                    //PullOut();
                }
                if (newEvidence.name == "Brochure")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    brochure = true;
                    //PullOut();
                }
                if (newEvidence.name == "Laptop")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    laptop = true;
                    //PullOut();
                }
                if (newEvidence.name == "Poison")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    poison = true;
                    //PullOut();
                }
                if (newEvidence.name == "RobPhone")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    robPhone = true;
                    //PullOut();
                }
                if (newEvidence.name == "RileyPhone")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    rileyPhone = true;
                    //PullOut();
                }
                if (newEvidence.name == "MattPhone")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    mattPhone = true;
                    //PullOut();
                }
                if (newEvidence.name == "SafeFlier")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                   // Destroy(newEvidence);
                    safeFlier = true;
                    //PullOut();
                }




            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                PullOut();


            }


        }
     if(isViewing && dialogueTriggered)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Next Sentence");
                newEvidence.GetComponent<DialogueTrigger>().NextSentence();
            }
            if(DM.endDialogue == true)
            {
                DM.endDialogue = false;
                dialogueTriggered = false;




            }

        }
    }
    public void PullOut()
    {
        isViewing = false;
        dialogueTriggered = false;
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
