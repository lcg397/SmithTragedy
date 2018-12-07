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
        if (isViewing && dialogueTriggered)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Next Sentence");
                newEvidence.GetComponent<DialogueTrigger>().NextSentence();
            }
            if (DM.endDialogue == true)
            {
                DM.endDialogue = false;
                dialogueTriggered = false;




            }

        }
        if (isViewing == true && dialogueTriggered == false)
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
                else if (newEvidence.name == "Letter")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    letter = true;
                    //PullOut();
                }
                else if (newEvidence.name == "Brochure")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    brochure = true;
                    //PullOut();
                }
                else if (newEvidence.name == "Laptop")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    laptop = true;
                    //PullOut();
                }
                else if (newEvidence.name == "Poison")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    poison = true;
                    //PullOut();
                }
                else if (newEvidence.name == "RobPhone")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    robPhone = true;
                    //PullOut();
                }
                else if (newEvidence.name == "RileyPhone")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    rileyPhone = true;
                    //PullOut();
                }
                else if (newEvidence.name == "MattPhone")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    mattPhone = true;
                    //PullOut();
                }
                else if (newEvidence.name == "SafeFlier")
                {
                    dialogueTriggered = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                   // Destroy(newEvidence);
                    safeFlier = true;
                    //PullOut();
                }




            }
           


        }
        if(isViewing == true)
        {

            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("OUT");
                PullOut();


            }

        }
     
    }
    public void PullOut()
    {
        isViewing = false;
        dialogueTriggered = false;
        playerCamera.fieldOfView = 60f;
        examineText.text = "Press E to Exzamine";
        inventoryUI.SetActive(false);
        GetComponent<Interaction>().ResetCharacterPosRot();



    }
    public void PullIn()
    {
        playerCamera.transform.LookAt(newEvidence.transform);
        inventoryUI.SetActive(true);
        evidenceDescription.text = newEvidence.GetComponent<EvidenceDescription>().evidenceDes;
        playerCamera.fieldOfView = 20f;
        
    }
}
