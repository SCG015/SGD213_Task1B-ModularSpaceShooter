using UnityEngine;
using System.Collections;


/// <summary>
/// 
/// </summary>
public class BulletMoveForward : MonoBehaviour {

    private float acceleration = 50f;

    private float initialVelocity = 5f;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        // Get and store a reference for the rigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // Add force to our rigidbody to create movement each frame
        Vector2 forceToAdd = Vector2.up * acceleration * Time.deltaTime;

        ourRigidbody.AddForce(forceToAdd);
    }
}
