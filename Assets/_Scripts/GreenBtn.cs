using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBtn : MonoBehaviour
{
    public Animator anim;
    public void OnTriggerEnter(Collider other)
    {
        anim.SetBool("Raise", true);
    }
    public void OnTriggerExit(Collider other)
    {
        anim.SetBool("Raise", false);
    }
}
