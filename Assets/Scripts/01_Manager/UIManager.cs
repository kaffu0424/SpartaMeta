using System.Collections;
using System.Collections.Generic;
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

    // 흠 이것만 있으면 UI Manager 싱글톤 없어도될거같은데..
}
