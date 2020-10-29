using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField] private float playerSpeed =60f;
    [SerializeField] private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    private Touch theTouch;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {

        transform.Translate(0, 0, playerSpeed * Time.deltaTime);

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 moveHorizontal = new Vector3(Input.GetAxis("Horizontal"), 0,0);
        controller.Move(moveHorizontal * Time.deltaTime * playerSpeed);

        //if (moveHorizontal != Vector3.zero)
        //{
        //    gameObject.transform.forward = moveHorizontal;
        //}

        // Changes the height position of the player..
        if (CrossPlatformInputManager.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);

            if (theTouch.phase == TouchPhase.Stationary)
            {
                playerSpeed = 0.0001f;
                transform.Translate(0, 0, playerSpeed * Time.deltaTime);
            }

            if (theTouch.phase == TouchPhase.Ended)
            {
                playerSpeed = 40f;
                transform.Translate(0, 0, playerSpeed * Time.deltaTime);
            }


        }
    }
}
