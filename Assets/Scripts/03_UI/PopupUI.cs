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

    public void OnPopup(string Text, Action enter = null, Action exit = null)
    {
        gameObject.SetActive(true);
        popupTEXT.text = Text;

        enterFunction = enter;
        exitFunction = exit;
    }

    public void PopupEnter()
    {
        gameObject.SetActive(false);
        enterFunction?.Invoke();
    }

    public void PopupExit()
    {
        gameObject.SetActive(false);
        exitFunction?.Invoke();
    }
}
