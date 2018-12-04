using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    public GameObject dialogueUI;
    public bool endDialogue;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();  
    }

public void StartDialogue(Dialogue dialogue)
    {
        if (dialogueUI.activeInHierarchy == false)
        {
            dialogueUI.SetActive(true);
        }
        if (nameText != null)
        {
            nameText.text = dialogue.name;
        }

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {

            sentences.Enqueue(sentence);

        }
        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {

        if(sentences.Count == 0)
        {
            EndDialogue();
            return;


        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    public void EndDialogue()
    {

        dialogueUI.SetActive(false);
        endDialogue = true;
        //sentences = new Queue<string>();
        player.GetComponent<Interaction>().ResetCharacterPosRot();

    }
}
