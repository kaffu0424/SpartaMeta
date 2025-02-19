using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcLuna : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UIManager.Instance.OnPopup("ĳ������ ������ \n���� �Ͻðڽ��ϱ�?", OnCustomCharacter);
        }
    }

    private void OnCustomCharacter()
    {
        UIManager.Instance.OffPopup();
        UIManager.Instance.OnCustomCharacter(true);
    }
}
