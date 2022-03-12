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
            other.GetComponent<Animator>().enabled = true;
            other.GetComponent<Animator>().SetBool("1", true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerMovement2>())
        {
            other.GetComponent<Animator>().SetBool("1", true);
            changePLayers.SetWining();
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
