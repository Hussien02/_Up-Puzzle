using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float playerSpeed;
    public float jumpSpeed;
    public float gravictValue = 6;

    bool isJumping = true;
    float initialJumpVelocity;

    [Header(" Jump ")]
    public float maxJumptime;
    public float maxJumpHight;
    public float gravityMultiplayer;

    [Header("player to be seleted ")]
    [Range(0, 1)]
    public int playerID;
    public PlayersManager SOPlayersManager;


    CharacterController CharacterController;
    Vector3 _InputVector;
    Vector3 movementVector = Vector3.zero;

    [HideInInspector] public bool IsplayerForcedJump = false;


    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
        JumpEquation();
    }

    void JumpEquation()
    {
        float timeToApix = maxJumptime / 2;
        initialJumpVelocity = (2 * maxJumpHight) / timeToApix;
        gravictValue = (-2 * maxJumpHight) / Mathf.Pow(timeToApix, 2);
    }

    void Update()
    {
        HandleJump();
        ApplyGravity();
        _InputVector = new Vector3((-1) * Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"), 0);

        //if (_InputVector.x == 0)
        //{
        //    movementVector.x = 0;
        //}
        movementVector.x = playerSpeed * Time.deltaTime * _InputVector.x;
        movementVector.x = Mathf.Clamp(movementVector.x, -playerSpeed, playerSpeed);

        if (SOPlayersManager.selecetedPLayer != playerID) movementVector.x= 0;
        CharacterController.Move(movementVector * Time.deltaTime);
    }


    #region Jump
    void HandleJump()
    {
        if (CharacterController.isGrounded && !isJumping)
        {
            if (Input.GetKeyDown(KeyCode.Space) && SOPlayersManager.selecetedPLayer == playerID)
            {
                isJumping = true;
                movementVector.y = initialJumpVelocity;
                Debug.Log("player " + gameObject.name + "  jump = " + movementVector.y);
            }
            else if (IsplayerForcedJump /*|| Input.GetKeyDown(KeyCode.L)*/)
            {
                IsplayerForcedJump = false;
                isJumping = true;
                movementVector.y = 1.3f * initialJumpVelocity;
                Debug.Log("player " + gameObject.name + "  jump = " + movementVector.y);
            }
        }
        if (CharacterController.isGrounded && isJumping && movementVector.y <= 0)
        {
            isJumping = false;
            gravityMultiplayer = 1;
        }
    }
    void ApplyGravity()
    {
        if (!CharacterController.isGrounded)
        {
            movementVector.y += gravictValue * Time.deltaTime;
        }
    }
    public void ForcePlayerToJump()
    {
        IsplayerForcedJump = true;
    }

    #endregion
}
