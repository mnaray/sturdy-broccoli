using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.EventSystems;

public class DialogueStarter : MonoBehaviour, IPointerDownHandler
{
    public NPCConversation myConversation;
    // private SturdyBroccoli playerControls;

    // private void Awake()
    // {
    //     playerControls = new SturdyBroccoli();
    // }

    // private void OnEnable()
    // {
    //     playerControls.Enable();
    // }

    // private void OnDisable()
    // {
    //     playerControls.Disable();
    // }

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
