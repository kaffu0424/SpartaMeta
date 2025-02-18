using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform target;
    private Vector3 offset;

    [SerializeField] private Vector2 minBounds;
    [SerializeField] private Vector2 maxBounds;

    private void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
        offset = new Vector3(0, 0, -10);
    }

    void LateUpdate()
    {
        // Ÿ�� ��ġ
        Vector3 targetPosition = target.position + offset;

        // ī�޶� ��ġ �̵�
        transform.position = Vector3.Lerp(transform.position, targetPosition, 5f * Time.deltaTime);

        // ī�޶� ��ġ �ּ�/�ִ밪 ����
        float clampX = Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x);
        float clampY = Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y);

        // �ּ�/�ִ밪 ���ѵ� ��ġ�� ����
        transform.position = new Vector3(clampX, clampY, transform.position.z);
    }
}
