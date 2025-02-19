using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinTheStack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            UIManager.Instance.OninteractionGuide(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            UIManager.Instance.OninteractionGuide(false);
    }

    private void Update()
    {
        if (!UIManager.Instance.IsOnGuide)
            return;

        if (Input.GetKeyDown(KeyCode.F))
            UIManager.Instance.OnPopup("미니게임\nThe Stack 입장하기", JoinGame);
    }
    public void JoinGame()
    {
        SceneManager.LoadScene("02_StackGame");
    }
}
