using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerReachesHisGola : MonoBehaviour
{
    public ChangePLayers changePLayers;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement2>())
        { 
            changePLayers.SetWining();
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerMovement2>())
        {
            changePLayers.SetWining();
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
