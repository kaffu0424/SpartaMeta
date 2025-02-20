using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DodgeManager : MonoBehaviour
{
    private static DodgeManager instance;
    public static DodgeManager Instance
    {
        get { return instance; }
    }

    private DodgeUI dodgeUI;
    private int score;

    private void Awake()
    {
        instance = this;
        dodgeUI = FindObjectOfType<DodgeUI>();
    }

    public void AddScore()
    {
        score++;
        dodgeUI?.UpdateScore(score);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        dodgeUI?.OnGameOverUI(score);
    }
    public void GameEnd()
    {
        Time.timeScale = 1;

        // 데이터 저장
        int bestScore = PlayerPrefs.GetInt(DataManager.DodgeBestScore, 0);
        if(bestScore < score)
            PlayerPrefs.SetInt(DataManager.DodgeBestScore, score);

        SceneManager.LoadScene("01_Main");
    }
}
