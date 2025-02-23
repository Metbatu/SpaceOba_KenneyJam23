using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Follow")]
    [SerializeField] private Transform followTargetTransform;
    [SerializeField] private Vector3 followOffset;

    [Header("Look At")]
    [SerializeField] private bool canLookAt;
    [SerializeField] private Transform lookAtTargetTransform;

    private void Update()
    {
        transform.position = followTargetTransform.position + followOffset;
        if (canLookAt) transform.LookAt(lookAtTargetTransform);
    }
}
