using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 100f;       
    public float rotationSpeed = 100f; 

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.Self);

        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime);
    }
}
