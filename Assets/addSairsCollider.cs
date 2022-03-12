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

}
