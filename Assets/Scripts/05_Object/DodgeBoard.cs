using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DodgeBoard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bestScoreTEXT;

    private void Start()
    {
        int score = PlayerPrefs.GetInt(DataManager.DodgeBestScore, 0);

        bestScoreTEXT.text = score.ToString();
    }
}
