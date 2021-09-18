using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();   
    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerMovement();

    }

    /// <summary>
    ///     Function that handles player movement.
    ///     It gets the axis value and multiply by deltaTime and moveSpeed (float).
    /// </summary>
    /// 
    /// <returns>
    ///     void
    /// </returns>
    void HandlePlayerMovement()
    {
        float xSpeed = (Input.GetAxis("Horizontal") * Time.deltaTime) * moveSpeed;
        float zSpeed = (Input.GetAxis("Vertical") * Time.deltaTime) * moveSpeed;

        transform.Translate(xSpeed, 0, zSpeed);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to Obstacle Course");
        Debug.Log("Use the Keyboard Arrows to move the player GameObject");
        Debug.Log("Have fun :D");
    }
}
