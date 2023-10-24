using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPC", menuName = "ScriptableObjects/NPC", order = 5)]
public class NPCSO : ScriptableObject
{
    public List<DialogueSO> _IntroDialogues { get; set; } = new List<DialogueSO>();
    public Dictionary<DialogueMood, Sprite> _SpritesByMood { get; set; } = new Dictionary<DialogueMood, Sprite>();
    
}
