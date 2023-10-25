using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// This script was taken from another project.
public class DialogueController : MonoBehaviour
{
    List<DialogueSO> dialogueList;
    DialogueSO currentDialogue;
    [SerializeField] Image _DialogueImage;
    [SerializeField] TextMeshProUGUI _DialogueText;
    [SerializeField] float _TextDelay;
    [SerializeField] Button _SkipDialogueButton;
    [SerializeField] CanvasGroup _DialogueHolder;
    private int _DialogueIndex = 0;
    bool typing;
    public static DialogueController Instance { get; set; }
    
    public enum DialogueType
    {
        Initial,
        CluePostQuestionSolve,
        RefuseExitAttempt
        }
    private void Awake()    
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else Instance = this;

        _SkipDialogueButton.onClick.AddListener(SkipCurrentDialogue);
        
    }
    public void StartSetOfDialogues(List<DialogueSO> thisDialogues) 
    {
        dialogueList = thisDialogues;
        _DialogueIndex = 0;
        _DialogueImage.color = new Color(1f, 1f, 1f, 0f);
        _DialogueHolder.alpha = 0f;
        Sequence dotseq = DOTween.Sequence();
        _DialogueText.text = "";
        dotseq.Append(_DialogueImage.DOFade(1f, 0.5f)).Append(_DialogueHolder.DOFade(1f, 0.5f)).OnComplete(RunNextDialogueOnList);
        UIController.Instance.OpenCanvas(UIScreen.Dialogue);
    }
    private void RunNextDialogueOnList() 
    {
        currentDialogue = dialogueList[this._DialogueIndex];

        StartCoroutine(TextCoroutine(currentDialogue.GetDialogueText()));        
        this._DialogueIndex++;
    }
    IEnumerator TextCoroutine(string textToAdd)
    {
        _DialogueText.text = "";
        typing = true;
        for (int i = 0; i < textToAdd.Length; i++)
        {
            _DialogueText.text = _DialogueText.text + textToAdd[i];
            yield return new WaitForSeconds(_TextDelay);
        }
        typing= false;
    }
    public void SkipCurrentDialogue() 
    {
        if (currentDialogue != null) 
        {
            if (typing)
            {
                StopAllCoroutines();
                _DialogueText.text = currentDialogue.GetDialogueText();
                typing = false;
            }
            else 
            {
                if (_DialogueIndex < dialogueList.Count) 
                {
                    RunNextDialogueOnList();
                }
                else { EndDialogueSet(); }
            }
        }
    }
    private void EndDialogueSet() 
    {
        
    }
    private void OnDestroy()
    {
        _SkipDialogueButton.onClick.RemoveListener(SkipCurrentDialogue);
    }
}
