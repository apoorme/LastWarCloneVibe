using UnityEngine;

public class SoldierMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 15f;
    public float xLimit = 4.5f;

    void Update()
    {
        // Get horizontal input (A/D or Left/Right arrows)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate new position
        Vector3 currentPosition = transform.position;
        float newX = currentPosition.x + horizontalInput * moveSpeed * Time.deltaTime;

        // Clamp the position so soldiers stay on the bridge
        newX = Mathf.Clamp(newX, -xLimit, xLimit);

        // Apply updated position
        transform.position = new Vector3(newX, currentPosition.y, currentPosition.z);
    }
}
