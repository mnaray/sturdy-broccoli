using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.EventSystems;

public class DialogueStarter : MonoBehaviour, IPointerDownHandler
{
    public NPCConversation myConversation;

    public void StartConversation()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ConversationManager.Instance.StartConversation(myConversation);
        Debug.Log("works");
    }
}
