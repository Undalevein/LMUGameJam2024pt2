using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public CircleCollider2D playerCollision;
    public float movementSpeed;

    private bool moveUp;
    private bool moveLeft;
    private bool moveDown;
    private bool moveRight;

    void Start()
    {
        moveUp = false;
        moveLeft = false;
        moveDown = false;
        moveRight = false;
        gameObject.name = "Player";
    }

    void Update()
    {
        // Menu Key Listener
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ;
        }

        // Movement Keys Listener
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveUp = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveDown = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveRight = true;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            moveUp = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            moveLeft = false;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            moveDown = false;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            moveRight = false;
        }

        // Interact Key Listener
        if (Input.GetKeyDown(KeyCode.E))
        {
            ;
        }

        // Player Movement
        if (moveUp) { transform.position += new Vector3(0, movementSpeed, 0); }
        if (moveLeft) { transform.position += new Vector3(-movementSpeed, 0); }
        if (moveDown) { transform.position += new Vector3(0, -movementSpeed, 0); }
        if (moveRight) { transform.position += new Vector3(movementSpeed, 0, 0); }
    }
}
