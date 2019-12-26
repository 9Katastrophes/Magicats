using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogueActive;

    public string[] dialogueLines;
    public int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        currentLine = 0;
        dialogueLines = new string[] {""};
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueActive && Input.GetMouseButtonDown(0)) {
            currentLine++;
        }
        if (currentLine >= dialogueLines.Length) {
            dBox.SetActive(false);
            dialogueActive = false;
            currentLine = 0;
        }

        dText.text = dialogueLines[currentLine];
    }

    public void ShowDialogue() {
        dialogueActive = true;
        dBox.SetActive(true);
    }
}
