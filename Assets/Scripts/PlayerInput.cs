using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;
    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0.0f)
        {
            playerMovementScript.HorizontalMovement(horizontalInput);
        }
        if (Input.GetButton("Fire1"))
        {
            if (shootingScript != null)
            {
                shootingScript.Shoot();
            }  
            else
            {
                UnityEngine.Debug.Log("Attach ShootingScript");
            }
        }
    }
}
