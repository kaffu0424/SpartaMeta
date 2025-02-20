using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DodgeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreTEXT;

    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private TextMeshProUGUI gameOverScore;
    [SerializeField] private Button gameOverButton;

    private void Start()
    {
        gameOverButton.onClick.AddListener(() => DodgeManager.Instance.GameEnd());
    }

    public void UpdateScore(int score)
    {
        scoreTEXT.text = $"SCORE : {score}";
    }

    public void OnGameOverUI(int score)
    {
        gameOverUI.SetActive(true);
        gameOverScore.text = score.ToString();
    }
}
