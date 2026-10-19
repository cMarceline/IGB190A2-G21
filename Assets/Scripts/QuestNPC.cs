using UnityEngine;
using TMPro;
public class QuestNPC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public GameObject dialoguePanel;
public TMP_Text dialougeText;


public string message = "Ohhh NOOOO go kill that vamprie or smth";

private void Start()
{
    dialoguePanel.SetActive(false);
}

private void OnMouseDown()
{
    dialougeText.text =message;
    dialoguePanel.SetActive(true);
}

public void CloseDialouge()
{
    dialoguePanel.SetActive(false);
}
}