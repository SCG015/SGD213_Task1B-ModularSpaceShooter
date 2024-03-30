using UnityEngine;
using System.Collections;


/// <summary>
/// We want our objects to rotate at random speeds
/// Provides some visual variance to the player
/// </summary>
public class Rotate : MonoBehaviour
{
    // Set maximum speed at which the objects will rotate
    [SerializeField]
    private float maximumSpinSpeed = 200;

    // Use this for initialization
    void Start()
    {
        // Apply rotation to a value in the range +/- maximuimSpinSPeed to our rigidbody
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);
    }
}
