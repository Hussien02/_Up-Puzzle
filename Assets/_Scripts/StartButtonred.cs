using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonred : MonoBehaviour
{
    public Animator anim;
    public Animator PushUPAnim;
    public ButtonsClicked buttonsClickedSO;
    private void OnTriggerEnter(Collider other)
    {
        buttonsClickedSO.redButtonClicked = true;
        anim.SetBool("DropGreen", true);
        PushUPAnim.SetBool("JumpBox", true);
    }

    public void OnTriggerExit(Collider other)
    {
        buttonsClickedSO.redButtonClicked = false;
        anim.SetBool("DropGreen", false);
        PushUPAnim.SetBool("JumpBox", false);

    }
}
