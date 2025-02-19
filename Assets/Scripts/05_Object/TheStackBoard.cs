using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TheStackBoard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bestScoreTEXT;
    [SerializeField] private TextMeshProUGUI bestComboTEXT;

    private void Start()
    {
        int score = PlayerPrefs.GetInt(DataManager.TheStackBestScore, 0);
        int combo = PlayerPrefs.GetInt(DataManager.TheStackBestCombo, 0);

        bestScoreTEXT.text = score.ToString();
        bestComboTEXT.text = combo.ToString();
    }
}
