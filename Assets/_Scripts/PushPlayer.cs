using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPlayer : MonoBehaviour
{
    public ButtonsClicked buttonsClickedSO;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player name is " + other.gameObject.name);
        if(buttonsClickedSO.redButtonClicked)
        other.GetComponent<PlayerMovement2>().ForcePlayerToJump();
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Player name is " + other.gameObject.name);
        if (buttonsClickedSO.redButtonClicked)
            other.GetComponent<PlayerMovement2>().ForcePlayerToJump();
    }
}
