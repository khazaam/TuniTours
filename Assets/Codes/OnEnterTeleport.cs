using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterTeleport : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            Teleport teleport = transform.parent.GetComponent<Teleport>();
            teleport.isEntered = true;
            teleport.currentTeleport = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Teleport teleport = transform.parent.GetComponent<Teleport>();
            teleport.isEntered = false;
        }
    }
}
