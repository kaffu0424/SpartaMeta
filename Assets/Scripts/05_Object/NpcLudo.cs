using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcLudo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UIManager.Instance.OnPopup("스파르타 내일배움캠프\n유니티!");
        }
    }
}
