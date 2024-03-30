using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;


/// <summary>
/// This handles the movement function of the bullet object 
/// </summary>
public class BulletMoveForward : MonoBehaviour, IEngine 
{
    // Set accellaration
    private float acceleration = 50f;
    // Set initialVelocity
    private float initialVelocity = 5f;

    private Rigidbody2D ourRigidbody;
  

    // Use this for initialization
    void Start()
    {
        // Get and store a reference for the rigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
        // Set the initial velocity of our rigidbody
        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

    /// <summary>
    /// Uses the IEngine interface and applies 
    /// force to the rigidbody in the value of direction
    /// </summary>
    /// <param name="direction">direction of movement supplied by MoveForwardConstantly</param>
    public void Move(Vector3 direction)
    {
        Vector2 forceToAdd = direction * acceleration * Time.deltaTime;

        ourRigidbody.AddForce(forceToAdd);
    }
}
