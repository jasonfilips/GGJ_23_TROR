using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleDialogueBox : MonoBehaviour
{
    [SerializeField] int lettersPerSecond;
    [SerializeField] Color highlightedColor;

    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] GameObject actionSelector;
    [SerializeField] GameObject moveSelector;
    [SerializeField] GameObject moveDetails;

    [SerializeField] List<TextMeshProUGUI> actionText;
    [SerializeField] List<TextMeshProUGUI> moveText;

    [SerializeField] TextMeshProUGUI energyText;
    [SerializeField] TextMeshProUGUI typeText;
    

    public void SetDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
    }

    public IEnumerator TypeDialogue(string dialog)
    {
        dialogueText.text = "";
        foreach (var letter in dialog.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);

        }
    }

    public void EnableDialogText(bool enabled)
    {
        dialogueText.enabled = enabled;
    }

    public void EnableActionSelector(bool enabled)
    {
        actionSelector.SetActive(enabled);
    }

    public void EnableMoveSelector(bool enabled)
    {
        moveSelector.SetActive(enabled);
        moveDetails.SetActive(enabled);
    }
    
    public void UpdateActionSelection(int selectedAction)
    {
        for (int i = 0; i < actionText.Count; ++i)
        {
            if (i == selectedAction)
            {
                actionText[i].color = highlightedColor;
            }
            else
            {
                actionText[i].color = Color.black;
            }
        }
    }

    public void UpdateMoveSelection(int selectedMove, Move move)
    {
        for (int i=0; i<moveText.Count; ++i)
        {
            if (i == selectedMove)
            {
                moveText[i].color = highlightedColor;
            }
            else
            {
                moveText[i].color = Color.black;
            }
        }

        energyText.text = $"Energy {move.Energy}/{move.Base.Energy}";
        typeText.text = move.Base.Type.ToString();
    }

    public void SetMoveNames(List<Move> moves)
    {
        for (int i=0; i<moveText.Count; ++i)
        {
            if (i < moves.Count)
            {
                moveText[i].text = moves[i].Base.Name;
            }
            else
            {
                moveText[i].text = "-";
            }
        }
    }
}
