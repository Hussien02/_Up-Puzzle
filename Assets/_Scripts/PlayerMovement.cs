using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    
    public float playerSpeed;
    public float jumpSpeed;

    public float gravictValue=6;
    Vector3 _InputVector;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _InputVector = new Vector3((-1)*Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical")*jumpSpeed,0 );

        Vector3 Upplayer = new Vector3 (0, -1 * gravictValue, 0);
        _InputVector = _InputVector + Upplayer;
        controller.Move(_InputVector * Time.deltaTime * playerSpeed);

    }
}
