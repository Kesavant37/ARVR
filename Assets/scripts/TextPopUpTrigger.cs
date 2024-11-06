using UnityEngine;
using UnityEngine.UI;
 using System.Collections;

public class TextPopUpTrigger : MonoBehaviour
{
    public GameObject textWindow;    // Assign the UI text window in the Inspector
    public Vector3 offset = new Vector3(0, 2, 0); // Position offset for the pop-up text

    void Start()
    {
        // Initially set the text window to inactive
        textWindow.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered is the Camera
        if (other.CompareTag("Main Camera"))
        {
            // Activate the text window
            textWindow.SetActive(true);

            // Set the position of the text window near the object with an offset
            textWindow.transform.position = transform.position + offset;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the object that exited is the Camera
        if (other.CompareTag("Main Camera"))
        {
            // Deactivate the text window
            textWindow.SetActive(false);
        }
    }
}
