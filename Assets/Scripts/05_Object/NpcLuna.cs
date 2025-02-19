using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcLuna : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UIManager.Instance.OnPopup("캐릭터의 색상을 \n변경 하시겠습니까?", OnCustomCharacter);
        }
    }

    private void OnCustomCharacter()
    {
        UIManager.Instance.OffPopup();
        UIManager.Instance.OnCustomCharacter(true);
    }
}
