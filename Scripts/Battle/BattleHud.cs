using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHud : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] HPBar hpBar;

    Character _character;

    public void SetData(Character character)
    {
        _character = character;

        nameText.text = character.Base.Name;
        levelText.text = "Lvl " + character.Level;
        hpBar.SetHP((float)character.HP/character.MaxHp);
    }

    public IEnumerator UpdateHP()
    {
        yield return hpBar.SetHPSmooth((float)_character.HP / _character.MaxHp);
    }
}
