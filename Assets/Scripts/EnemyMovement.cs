using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public Vector3 direction = Vector3.back; // Vector3.back is (0, 0, -1)

    void Update()
    {
        // Move constant in the specified direction
        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
    }
}
