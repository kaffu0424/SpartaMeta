using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI popupTEXT;
    private Action enterFunction;
    private Action exitFunction;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
            PopupEnter();

        if (Input.GetKeyDown(KeyCode.Escape))
            PopupExit();
    }

    public void SetPopup(string Text, Action enter = null, Action exit = null)
    {
        popupTEXT.text = Text;

        enterFunction = enter;
        exitFunction = exit;
    }

    private void PopupEnter()
    {
        UIManager.Instance.OffPopup();
        enterFunction?.Invoke();
    }

    private void PopupExit()
    {
        UIManager.Instance.OffPopup();
        exitFunction?.Invoke();
    }
}
