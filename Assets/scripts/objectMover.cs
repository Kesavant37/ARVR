using UnityEngine;

public class CustomKeyRotationHandler : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotate around the Y-axis (Q and E keys)
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime, Space.World);
        }

        // Rotate around the X-axis (R and F keys)
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(Vector3.right, -rotationSpeed * Time.deltaTime);
        }
    }
}
