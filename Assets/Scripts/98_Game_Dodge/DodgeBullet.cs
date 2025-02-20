using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);

            DodgeManager.Instance.GameOver();

            return;
        }

        if(collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
            return;
        }
    }
}
