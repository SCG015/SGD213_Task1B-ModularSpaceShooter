using UnityEngine;
using System.Collections;
using System.Collections.Specialized;


/// <summary>
/// Handles the movement of the player
/// </summary>
public class PlayerMovementScript : MonoBehaviour, IEngine
{
    // Indicates how fast we accelerate
    [SerializeField]
    private float playerSpeed = 5000f;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        // Get and store a reference to OurRigidbodyComponent
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Uses the IEngine interface and applies
    /// force to the rigidbody in the value of direction
    /// </summary>
    /// <param name="direction">Direction of movement suplied by player input</param>
    void IEngine.Move(Vector3 direction)

    {
        // Add force to rigidbody in the direction speed of horizontalInput and playerSpeed
        Vector2 forceToAdd = direction * playerSpeed * Time.deltaTime;
        ourRigidbody.AddForce(forceToAdd);
    }
}
