using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the basic NPC information for any NPC.
[CreateAssetMenu(fileName = "NPCSO", menuName = "ScriptableObjects/NPC", order = 5)]
public class NPCSO : ScriptableObject
{
    [SerializeField] public List<DialogueSO> _InteractionBasicDialogues = new List<DialogueSO>();
    [SerializeField] public Dictionary<DialogueMood, Sprite> _SpritesByMood = new Dictionary<DialogueMood, Sprite>();
    
}
