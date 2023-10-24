using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "ScriptableObjects/Dialogue", order = 2)]
public class DialogueSO : ScriptableObject
{
    [SerializeField][TextArea] string _DialogueText;
    [SerializeField] DialogueMood _Mood;

    [SerializeField] List<string> choices;
    public string GetDialogueText() { return _DialogueText; }
    public DialogueMood GetImage() { return _Mood; }
    public List<string> GetChoices() { return choices; }
}

public enum DialogueMood 
{
    Default,
    Happy
}
