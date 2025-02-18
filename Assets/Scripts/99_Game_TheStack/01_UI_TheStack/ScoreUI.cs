using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : TheStackBaseUI
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
    [SerializeField]
    private TextMeshProUGUI comboText;
    [SerializeField]
    private TextMeshProUGUI bestScoreText;
    [SerializeField]
    private TextMeshProUGUI bestComboText;
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Button exitButton;

    private Transform scoreTextTransform;
    protected override UIState GetUIState()
    {
        return UIState.Score;
    }

    public override void Init(TheStackUI uiManager)
    {
        base.Init(uiManager);

        scoreTextTransform = transform.Find("Score");

        scoreText = scoreTextTransform.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        comboText = scoreTextTransform.Find("ComboText").GetComponent<TextMeshProUGUI>();
        bestScoreText = scoreTextTransform.Find("BestScoreText").GetComponent<TextMeshProUGUI>();
        bestComboText = scoreTextTransform.Find("BestComboText").GetComponent<TextMeshProUGUI>();

        startButton = transform.Find("StartButton").GetComponent<Button>();
        exitButton = transform.Find("ExitButton").GetComponent<Button>();

        startButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    public void SetUI(int score, int combo, int bestScore, int bestCombo)
    {
        scoreText.text = score.ToString();
        comboText.text = combo.ToString();
        bestScoreText.text = bestScore.ToString();
        bestComboText.text = bestCombo.ToString();
    }

    private void OnClickStartButton()
    {
        uiManager.OnClickStart();
    }

    private void OnClickExitButton()
    {
        uiManager.OnClickExit();
    }
}
