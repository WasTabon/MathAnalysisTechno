using UnityEngine;

public class BezierFollow : MonoBehaviour
{
    public Transform[] controlPoints;
    public float duration = 5f;
    public bool loop = true;

    private float t = 0f; // Время

    void Update()
    {
        t += Time.deltaTime / duration;

        if (t > 1f)
        {
            if (loop)
                t = 0f;
            else
                t = 1f;
        }
        
        Vector3 newPosition = BezierCurve.GetPoint(controlPoints[0].position, controlPoints[1].position, controlPoints[2].position, controlPoints[3].position, t);
        transform.position = newPosition;
    }
}