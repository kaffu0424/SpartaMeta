using System;
using UnityEngine;

public class UIManager : Singleton_Mono<UIManager>
{
    [SerializeField] private PopupUI popupUI;
    [SerializeField] private CustomCharacter customCharacter;

    private bool isMovementBlocked;

    // Get Set
    public PopupUI Popup => popupUI;
    public CustomCharacter CustomCharacter => customCharacter;
    public bool IsMovementBlocked => isMovementBlocked;

    protected override void InitializeManager()
    {
        isMovementBlocked = false;
        popupUI = FindObjectOfType<PopupUI>(true);
        customCharacter = FindObjectOfType<CustomCharacter>(true);
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

    public void OnCustomCharacter(bool active)
    {
        isMovementBlocked = active;
        customCharacter.gameObject.SetActive(active);
    }
}
