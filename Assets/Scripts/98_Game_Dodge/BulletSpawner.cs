using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    private float minPosX;
    private float maxPosX;
    private float posY;
    private int spawnCount;

    private float posX => Random.Range(minPosX, maxPosX);

    void Start()
    {
        minPosX = -8;
        maxPosX = 8;
        posY = transform.position.y;

        spawnCount = 1;

        StartCoroutine(SpawnBullet());
    }

    private IEnumerator SpawnBullet()
    {
        yield return new WaitForSeconds(1);

        while (true)
        {
            for(int i = 0; i < spawnCount; i++)
            {
                Transform newBullet = Instantiate(bullet).transform;

                newBullet.position = new Vector2(posX, posY);

                yield return new WaitForSeconds(0.15f);
            }

            spawnCount++;
            DodgeManager.Instance?.AddScore();
            yield return new WaitForSeconds(0.75f);
        }
    }
}
