using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DialogueHolder : MonoBehaviour
{
    public DialogueManager dMan;
    public string[] dialogueLines;


    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Speak() {
        if (!dMan.dialogueActive) {
            dMan.dialogueLines = dialogueLines;
            dMan.currentLine = 0;
            dMan.ShowDialogue();
        }
    }
}
