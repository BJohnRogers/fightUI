using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float moveSpeed = 5.0f;
    private CharacterController playerController;

    private Vector3 moveDirection;
    private Vector2 currentInput;


    // Start is called before the first frame update
    void Start()
    {

        playerController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        playerMove();

    }

    private void playerMove()
    {

        currentInput = new Vector2(moveSpeed * Input.GetAxis("Vertical"), moveSpeed * Input.GetAxis("Horizontal"));

        moveDirection = (transform.TransformDirection(Vector3.up) * currentInput.x + transform.TransformDirection(Vector3.left) * currentInput.y);

        playerController.Move(moveDirection * Time.deltaTime);

    }


}
