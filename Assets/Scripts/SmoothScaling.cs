using UnityEngine;

public class SmoothScaling : MonoBehaviour
{
    public float frequency = 1f;
    public float amplitude = 1f; 
    public float speed = 1f; 

    private Vector3 initialScale;
    private float time = 0f; 

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        time += Time.deltaTime * speed;

        float scale = Mathf.Sin(time * frequency) * amplitude;
        
        transform.localScale = initialScale * (1f + scale);
    }
}