using UnityEngine;

public class RemoveRigidbody : MonoBehaviour
{
    void Start()
    {
        // Check if the GameObject has a Rigidbody component
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Destroy the Rigidbody component
            Destroy(rb);
            Debug.Log("Rigidbody component removed from " + gameObject.name);
        }
        else
        {
            Debug.Log("No Rigidbody component found on " + gameObject.name);
        }
    }
}
