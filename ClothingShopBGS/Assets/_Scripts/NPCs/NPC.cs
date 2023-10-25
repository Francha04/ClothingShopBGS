using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, Interactable
{
    public NPCSO _NPCDataSO;

    public void StartInteraction()
    {
        DialogueController.Instance.StartSetOfDialogues(_NPCDataSO._InteractionBasicDialogues); 
    }

}
