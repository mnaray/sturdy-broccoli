using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.EventSystems;

public class DialogueStarter : MonoBehaviour, IPointerDownHandler
{
    public NPCConversation myConversation;
    public Rigidbody2D playerRB;
    public GameObject playerObject;
    public float interactionRadius = 1.0f;

    public void StartConversation()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }

    public void DisableMovement()
    {
        playerRB.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    }

    public void EnableMovement()
    {
        playerRB.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!ConversationManager.Instance.IsConversationActive
        && Vector2.Distance(playerObject.transform.position, transform.position) < interactionRadius)
        {
            StartConversation();
            DisableMovement();
        }
    }
}
