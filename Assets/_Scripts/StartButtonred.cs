using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonred : MonoBehaviour
{

    public ButtonsClicked buttonsClickedSO;
    private void OnTriggerEnter(Collider other)
    {
        buttonsClickedSO.redButtonClicked = true;
    }

    public void OnTriggerExit(Collider other)
    {
        {
            buttonsClickedSO.redButtonClicked = false;
        }
    }
}
