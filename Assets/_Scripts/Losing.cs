using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Losing : MonoBehaviour
{
    [SerializeField] GameObject LosingPanal;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Losing Collision");
        if (collision.collider.gameObject.GetComponent<PlayerMovement2>())
        {
            LosingCase();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Losing trigger ");
        if (other.gameObject.GetComponent<PlayerMovement2>())
        {
            LosingCase();
        }
    }

    void LosingCase()
    {
        Debug.Log("Losing ");
        LosingPanal.SetActive(true);
    }
}
