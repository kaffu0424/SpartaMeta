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

    private bool isMovementBlocked;
    public bool IsMovementBlocked { get { return isMovementBlocked; } }

    protected override void InitializeManager()
    {
        isMovementBlocked = false;
        popupUI = FindObjectOfType<PopupUI>(true);
    }

    public void OnPopup(string Text, Action enter = null, Action exit = null)
    {
        if (popupUI == null)
            return;

        isMovementBlocked = true;

        popupUI.gameObject.SetActive(true);
        popupUI.SetPopup(Text, enter);
    }

    public void OffPopup()
    {
        isMovementBlocked = false;
        popupUI.gameObject.SetActive(false);
    }
}
