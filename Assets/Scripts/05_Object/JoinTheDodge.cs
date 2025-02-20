using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinTheDodge : MonoBehaviour
{
    private bool triggerDodge = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerDodge = true;
            UIManager.Instance.OninteractionGuide(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerDodge = false;
            UIManager.Instance.OninteractionGuide(false);
        }
    }

    private void Update()
    {
        if (!triggerDodge)
            return;

        if (Input.GetKeyDown(KeyCode.F))
            UIManager.Instance.OnPopup("미니게임\nDodge Game 입장하기", JoinGame);
    }
    public void JoinGame()
    {
        SceneManager.LoadScene("03_DodgeGame");
    }
}
