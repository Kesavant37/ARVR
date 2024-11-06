using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CubeTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("StoneCharacter script has started.");
    }
    public NPCConversation myConversation;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter triggered.");

        if (myConversation == null)
        {
            Debug.LogError("myConversation is not assigned in the Inspector.");
            return;
        }

            if (ConversationManager.Instance == null)
            {
                Debug.LogError("ConversationManager.Instance is null.");
                return;
            }
            else
            {
                Debug.Log("ConversationManager.Instance is available.");
            }

            try
            {
                Debug.Log("Attempting to start conversation.");
                ConversationManager.Instance.StartConversation(myConversation);
                Debug.Log("Conversation started successfully.");
            }
            catch (System.Exception ex)
            {
                Debug.LogError("Error starting conversation: " + ex.Message);
            }
        }
}
