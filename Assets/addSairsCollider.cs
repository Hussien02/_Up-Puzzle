using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addSairsCollider : MonoBehaviour
{
    public Animator _1stPlayerAnimator;
    public Animator _2ndPlayerAnimator;
    public BoxCollider boxCollider;

    public void enableboxcollider()
    {
        boxCollider.enabled = true;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement2>())
        {
            other.GetComponent<Animator>().enabled = true;
            other.GetComponent<Animator>().SetBool("2", true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerMovement2>())
        {
            other.GetComponent<Animator>().SetBool("2", true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

}
