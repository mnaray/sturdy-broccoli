using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockRotation : MonoBehaviour
{
    public Transform ownTransform;
    public Transform playerTransform;
    public Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = ownTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {   
        ownTransform.SetPositionAndRotation(new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z - 10), rotation);
    }
}
