using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.EventSystems;

public class DialogueStarter : MonoBehaviour, IPointerDownHandler
{
    public NPCConversation myConversation;
    public Rigidbody2D player;

    public void StartConversation()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }

    public void DisableMovement()
    {
        player.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    }

    public void EnableMovement()
    {
        player.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!ConversationManager.Instance.IsConversationActive)
        {
            StartConversation();
            DisableMovement();
        }
    }
}
