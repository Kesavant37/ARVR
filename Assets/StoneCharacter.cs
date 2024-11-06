using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class StoneCharacter : MonoBehaviour
{
    public NPCConversation myConversation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Main Camera"))
        {
            if (myConversation != null && ConversationManager.Instance != null)
            {
                ConversationManager.Instance.StartConversation(myConversation);
            }
            else
            {
                Debug.LogWarning("Conversation or ConversationManager is missing.");
            }
        }
    }
}
