using UnityEngine;
using System.Collections;


/// <summary>
/// This handles the movement function of the enemy object
/// </summary>
public class EnemyMoveForward : MonoBehaviour, IEngine 
{
    // Set acceleration
    private float acceleration = 75f;
    // Set initial velocity
    private float initialVelocity = 2f;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        // Get and store a reference for the rigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
        // Set the initial velocity of our rigidbody
        ourRigidbody.velocity = Vector2.down * initialVelocity;
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
