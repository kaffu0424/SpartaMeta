using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform target;
    private Vector3 offset;

    private void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
        offset = new Vector3(0, 0, -10);
    }

    void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.1f);
    }
}
