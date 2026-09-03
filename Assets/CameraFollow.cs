using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // The target object the camera will follow (e.g., the player)
    [SerializeField] private Transform target; 
    
    // The static distance offset between the camera and the target
    [SerializeField] private Vector3 offset = new Vector3(0f, 5f, -10f); 
    
    // Time taken for the camera to catch up to the target (lower is faster)
    [SerializeField] private float smoothTime = 0.25f; 

    private Vector3 currentVelocity = Vector3.zero;

    // LateUpdate runs after all standard Update movement calculations are finished
    private void LateUpdate()
    {
        if (target == null) return;

        // Determine the target destination for the camera
        Vector3 targetPosition = target.position + offset;

        // Smoothly transition the camera position toward the target position over time
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);
    }
}