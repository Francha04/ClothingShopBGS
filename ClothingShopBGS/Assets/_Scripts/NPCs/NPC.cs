using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, Interactable
{
    [SerializeField] List<DialogueSO> _IntroDialogues;
    public void StartInteraction()
    {
        DialogueController.Instance.StartSetOfDialogues(_IntroDialogues);
    }

}
