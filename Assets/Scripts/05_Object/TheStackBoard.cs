using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TheStackBoard : MonoBehaviour
{
    private const string BestScoreKey = "BestScore";
    private const string BestComboKey = "BestCombo";

    [SerializeField] private TextMeshProUGUI bestScoreTEXT;
    [SerializeField] private TextMeshProUGUI bestComboTEXT;

    private void Start()
    {
        int score = PlayerPrefs.GetInt(BestScoreKey, 0);
        int combo = PlayerPrefs.GetInt(BestComboKey, 0);

        bestScoreTEXT.text = score.ToString();
        bestComboTEXT.text = combo.ToString();
    }
}
