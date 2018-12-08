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
    public GameObject inventoryUI, JournalUI;

    public Text evidenceDescription, examineText;
    public bool murderWeapon, letter, brochure, laptop, robPhone, rileyPhone, mattPhone, poison, safeFlier, mattBody, rileyBody, jenBody, robBody;
    public bool isViewing, dialogueTriggered, journalOpen;
    public Text foundUI;
    public int foundNum;
    public WhoDoneItManager whom;
    
    // Start is called before the first frame update
    void Start()
    {
        DM = FindObjectOfType<DialogueManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(foundNum >= 11)
        {

            whom.foundAll = true;

        }
        foundUI.text = foundNum.ToString(); 
        if (!journalOpen)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                JournalUI.SetActive(true);
                journalOpen = true;


            }
        }

        else if (journalOpen)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                JournalUI.SetActive(false);
                journalOpen = false;

            }
        }
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
                    if (!murderWeapon)
                    {
                        foundNum +=  1;
                    }
                    murderWeapon = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                 
                    //PullOut();

                }
                else if (newEvidence.name == "Matt")
                {
                    
                    dialogueTriggered = true;
                    if (!mattBody)
                    {
                        foundNum += 1;
                    }
                    mattBody = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                   
                    //PullOut();
                }
                else if (newEvidence.name == "Jen")
                {
                  
                    dialogueTriggered = true;
                    if (!jenBody)
                    {
                        foundNum += 1;
                    }
                    jenBody = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    
                    //PullOut();
                }
                else if (newEvidence.name == "Riley")
                {
                  
                    dialogueTriggered = true;
                    if (!rileyBody)
                    {
                        foundNum += 1;
                    }
                    rileyBody = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    
                    //PullOut();
                  
                }
                else if (newEvidence.name == "Rob")
                {
                 
                    dialogueTriggered = true;
                    if (!robBody)
                    {
                        foundNum += 1;
                    }
                    robBody = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    
                    //PullOut();
                }
                else if (newEvidence.name == "Matt Letter")
                {
               
                    dialogueTriggered = true;
                    if (!letter)
                    {
                        foundNum += 1;
                    }
                    letter = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    
                    //PullOut();
                }
                else if (newEvidence.name == "Brochure")
                {
               
                    dialogueTriggered = true;
                    if(!brochure)
                    {

                        foundNum += 1;

                    }
                    brochure = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    
                    //PullOut();
                }
                else if (newEvidence.name == "Laptop")
                {
                    
                    dialogueTriggered = true;
                    if (!laptop)
                    {

                        foundNum += 1;

                    }
                    laptop = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    
                    //PullOut();
                }
                else if (newEvidence.name == "Poison")
                {
                    
                    dialogueTriggered = true;
                    if (!poison)
                    {

                        foundNum += 1;

                    }
                    poison = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                   
                    //PullOut();
                }
                else if (newEvidence.name == "RobPhone")
                {
                    
                    dialogueTriggered = true;
                    if (!robPhone)
                    {

                        foundNum += 1;

                    }
                    robPhone = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    
                    //PullOut();
                }
                else if (newEvidence.name == "RileyPhone")
                {
                    
                    dialogueTriggered = true;
                    if (!rileyPhone)
                    {

                        foundNum += 1;

                    }
                    rileyPhone = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                    
                    //PullOut();
                }
                else if (newEvidence.name == "MattPhone")
                {
                   
                    dialogueTriggered = true;
                    if (!mattPhone)
                    {

                        foundNum += 1;

                    }
                    mattPhone = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                    //Destroy(newEvidence);
                  
                    //PullOut();
                }
                else if (newEvidence.name == "SafeFlier")
                {
                    
                    dialogueTriggered = true;
                    if (!safeFlier)
                    {

                        foundNum += 1;

                    }
                    safeFlier = true;
                    newEvidence.GetComponent<DialogueTrigger>().TriggerDialogue();
                   // Destroy(newEvidence);
                    
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
        examineText.text = "Press E to Examine";
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
