using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


/// <summary>
/// 
/// </summary>
public class PlayerInput : MonoBehaviour
{

    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;
    
    // Start is called before the first frame update
    void Start()
    {
        // Get references for Player Movement and Shooting script components
        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set the input value from Horizontal input in 
        float horizontalInput = Input.GetAxis("Horizontal");

        // If input is detected that is greater than the deadzone of 0
        if (horizontalInput != 0.0f)
        {
            // Send horizontal movement input to the playerMovementScript
            playerMovementScript.HorizontalMovement(horizontalInput - + 0 );
        }
        // When Fire1 is pressed
        if (Input.GetButton("Fire1"))
        {
            // As long as the shootingScript is populated
            if (shootingScript != null)
            {
                // Run the shoot method
                shootingScript.Shoot();
            } 
            
            // Otherwise print a message to the log reminding to populate
            else
            {
                UnityEngine.Debug.Log("Attach ShootingScript");
            }
        }
    }
}
