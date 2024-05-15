using System;
using _app.Scripts;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Movement Components")]
    public float movementSpeed;
    public Vector3 jumpforce;
    public Vector3 movementVector;
    public bool crouching;

    [Header("Player Components")]
    public Rigidbody rb;
    public Camera playerCamera;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayerJump();
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.IncreaseScore();
            }
        }

        if(Input.GetKey(KeyCode.W))
        {
            movementVector.z = 1;
        }
        if(Input.GetKey(KeyCode.S))
        {
            movementVector.z = -1;
        }
        if(Input.GetKey(KeyCode.A))
        {
            movementVector.x = -1;
        }
        if(Input.GetKey(KeyCode.D))
        {
            movementVector.x = 1;
        }

        PlayerMovement(movementVector);
    }

    private void PlayerJump()
    {
        rb.AddForce(jumpforce, ForceMode.Impulse);
    }

    private void PlayerMovement(Vector2 movement)
    {
        transform.Translate(translation:new Vector3(movement.x, y:0, movement.y) * movementSpeed * Time.deltaTime);
    }
}
