using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script taken from another project.
[CreateAssetMenu(fileName = "Dialogue", menuName = "ScriptableObjects/Dialogue", order = 2)]
public class DialogueSO : ScriptableObject
{
    [SerializeField][TextArea] string _DialogueText;
    [SerializeField] DialogueMood _Mood; //This will not be used in the task. It represents the mood of the dialogue so the NPC can adjust its image accordingly.

    [SerializeField] List<string> choices = new List<string>();
    public string GetDialogueText() { return _DialogueText; }
    public DialogueMood GetMood() { return _Mood; }
    public List<string> GetChoices() { return choices; }
}

public enum DialogueMood 
{
    Default,
    Happy
}
