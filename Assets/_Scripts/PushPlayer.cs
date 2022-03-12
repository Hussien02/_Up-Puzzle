using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPlayer : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player name is " + other.gameObject.name);
        other.GetComponent<PlayerMovement2>().ForcePlayerToJump();
    }
}
