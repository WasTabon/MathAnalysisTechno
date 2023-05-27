using UnityEngine;

public class ParabolicMovement : MonoBehaviour
{
    public float initialSpeed = 10f;
    public float gravity = -9.8f;

    private Vector3 initialPosition;
    private float time = 0f;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        time += Time.deltaTime;
        
        float displacementY = (0.5f * gravity * time * time) + (initialSpeed * time);
        Vector3 newPosition = initialPosition + new Vector3(0f, displacementY, 0f);
        
        transform.position = newPosition;
    }
}