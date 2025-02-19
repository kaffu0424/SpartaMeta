using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomCharacter : MonoBehaviour
{
    // Player
    private SpriteRenderer playerSprite;
    [SerializeField] private Image previewImage;

    // Color
    [SerializeField] private Slider slider_Red;
    [SerializeField] private Slider slider_Green;
    [SerializeField] private Slider slider_Blue;

    // Text
    [SerializeField] private TextMeshProUGUI colorValues;

    // Button
    [SerializeField] private Button confirmButton;

    private void Start()
    {
        // Component
        // 플레이어 찾기 -> 플레이어 SpriteRenderer 찾기
        PlayerMovement player = FindObjectOfType<PlayerMovement>();
        playerSprite = player.GetComponentInChildren<SpriteRenderer>();

        // 값 초기화
        slider_Red.value = playerSprite.color.r * 255;
        slider_Green.value = playerSprite.color.g * 255;
        slider_Blue.value = playerSprite.color.b * 255; 

        UpdateValues();

        // 이벤트 초기화
        slider_Red.onValueChanged.AddListener(UpdateValues);
        slider_Green.onValueChanged.AddListener(UpdateValues);
        slider_Blue.onValueChanged.AddListener(UpdateValues);

        confirmButton.onClick.AddListener(ColorComfirm);
    }

    private void UpdateValues(float arg0 = 0)
    {

        float r = slider_Red.value;
        float g = slider_Green.value; 
        float b = slider_Blue.value;

        colorValues.text = $"Color( {r}, {g}, {b} )";


        previewImage.color = new Color(r / 255, g / 255, b / 255);
    }

    private void ColorComfirm()
    {
        float r = slider_Red.value;
        float g = slider_Green.value;
        float b = slider_Blue.value;

        playerSprite.color = new Color(r / 255, g / 255, b / 255);

        UIManager.Instance.OnCustomCharacter(false);
    }
}
