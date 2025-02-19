using System;
using UnityEngine;

public class UIManager : Singleton_Mono<UIManager>
{
    [SerializeField] private PopupUI popupUI;
    public PopupUI Popup 
    { 
        get 
        {
            if (popupUI == null)
                popupUI = FindObjectOfType<PopupUI>(true);

            return popupUI; 
        } 
    }

    protected override void InitializeManager()
    { }

    public void OnPopup(string Text, Action enter = null, Action exit = null)
    {
        if (popupUI == null)
            return;

        popupUI.gameObject.SetActive(true);
        popupUI.OnPopup(Text, enter);
    }
}
