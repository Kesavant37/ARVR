using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float mSpeed = 100f;       // Speed for camera movement
    public float rSpeed = 100f; // Speed for camera rotation

    void Update()
    {
        // Get input for horizontal and vertical movement
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float moveVertical = Input.GetAxis("Vertical");     // W/S or Up/Down

        // Calculate movement direction restricted to X and Z axes
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Move the camera relative to its current orientation
        transform.Translate(movement * mSpeed * Time.deltaTime, Space.Self);

        // Get mouse input for horizontal rotation only
        float mouseX = Input.GetAxis("Mouse X"); // Horizontal mouse movement

        // Rotate the camera around the Y axis only
        transform.Rotate(Vector3.up, mouseX * rSpeed * Time.deltaTime);
    }
}
