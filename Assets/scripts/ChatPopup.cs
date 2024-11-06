using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatPopup : MonoBehaviour, IInteractable
{
    public GameObject chatPanel;
    public Text chatText;
    public string message = "Hello, this is a chat message!";

    private void Start()
    {
        if (chatPanel != null)
        {
            chatPanel.SetActive(false); 
        }
    }

    public void Interact()
    {
        if (chatPanel != null)
        {
            chatText.text = message; 
            chatPanel.SetActive(true); 
            Invoke("HideChat", 10f);
        }
    }

    private void HideChat()
    {
        chatPanel.SetActive(false);
    }
}

