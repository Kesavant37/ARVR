using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light sun; // Directional light representing the sun
    public float dayLengthInMinutes = 1; // Total day duration in minutes

    private float rotationSpeed;

    void Start()
    {
        if (sun == null)
        {
            Debug.LogError("Sun (Directional Light) is not assigned.");
            return;
        }

        // Calculate rotation speed based on the desired day length
        rotationSpeed = 360f / (dayLengthInMinutes * 60f); // 360 degrees in 'x' seconds
    }

    void Update()
    {
        // Rotate the sun based on the calculated speed
        sun.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        
        // Adjust light intensity to simulate night and day
        float dot = Vector3.Dot(sun.transform.forward, Vector3.down);
        sun.intensity = Mathf.Clamp01(dot * 2f); // Strongest intensity at noon, zero at midnight
    }
}
