using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


/// <summary>
/// PlayerInput handles all of the input from the player, 
/// and passes the input information to the components
/// </summary>
public class PlayerInput : MonoBehaviour
{
    private ShootingScript shootingScript;
    private IEngine engine;
    
    // Start is called before the first frame update
    void Start()
    {
        // Get references for Shooting script
        shootingScript = GetComponent<ShootingScript>();
        // and our IEngine components
        engine = GetComponent<IEngine>();
 
    }

    // Update is called once per frame
    void Update()
    {

        // As long as the engine is populated
        if (engine != null)
        {
            // Set the input value from Horizontal input
            float input = Input.GetAxis("Horizontal");
            // Send horizontal movement input to 
            engine.Move(Vector3.right * input);
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
