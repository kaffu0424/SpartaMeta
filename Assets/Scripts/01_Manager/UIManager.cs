using System;
using UnityEngine;

public class UIManager : Singleton_Mono<UIManager>
{
    [SerializeField] private PopupUI popupUI;
    [SerializeField] private int a;

    private bool isMovementBlocked;

    public PopupUI Popup => popupUI;
    public bool IsMovementBlocked => isMovementBlocked;

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
