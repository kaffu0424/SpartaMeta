using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinTheStack : MonoBehaviour
{
    [SerializeField] private GameObject interactionGuide;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            interactionGuide.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            interactionGuide.SetActive(false);
    }

    private void Update()
    {
        if (!interactionGuide.activeSelf)
            return;

        if (Input.GetKeyDown(KeyCode.F))
            UIManager.Instance.Popup.OnPopup("�̴ϰ���\nThe Stack �����ϱ�", JoinGame);
    }
    public void JoinGame()
    {
        SceneManager.LoadScene("02_StackGame");
    }
}
