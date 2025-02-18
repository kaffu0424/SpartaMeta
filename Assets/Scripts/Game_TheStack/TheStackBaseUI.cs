using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TheStackBaseUI : MonoBehaviour
{
    protected TheStackUI uiManager;

    public virtual void Init(TheStackUI uiManager)
    {
        this.uiManager = uiManager;
    }

    protected abstract UIState GetUIState();

    public void SetActive(UIState state)
    {
        gameObject.SetActive(GetUIState() == state);
    }
}
