using UnityEngine;

public class DeceleratingMovement : MonoBehaviour
{
    public float initialSpeed = 10f;
    public float decelerationRate = 2f;

    private float time = 0f;
    private float distance = 0f;

    void Update()
    {
        float deltaTime = Time.deltaTime;
        float currentSpeed = initialSpeed / (1 + decelerationRate * time);
        distance += currentSpeed * deltaTime;
        time += deltaTime;
        
        Vector3 newPosition = transform.position + transform.forward * distance;
        transform.position = newPosition;
    }
}
