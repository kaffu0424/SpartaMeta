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
        // 타겟 위치
        Vector3 targetPosition = target.position + offset;

        // 카메라 위치 이동
        transform.position = Vector3.Lerp(transform.position, targetPosition, 5f * Time.deltaTime);

        // 카메라 위치 최소/최대값 제한
        float clampX = Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x);
        float clampY = Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y);

        // 최소/최대값 제한된 위치로 수정
        transform.position = new Vector3(clampX, clampY, transform.position.z);
    }
}
