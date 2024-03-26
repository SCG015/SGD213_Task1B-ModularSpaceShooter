using UnityEngine;
using System.Collections;


/// <summary>
/// 
/// </summary>
public class PlayerMovementScript : MonoBehaviour {
            // SerializeField exposes this value to the Editor, but not to other Scripts!
            // It is "pseudo public"
            // HorizontalPlayerAcceleration indicates how fast we accelerate Horizontally
            [SerializeField]
            private float playerSpeed = 5000f;

            private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start() {
        // Get and store a reference to OurRigidbodyComponent
        ourRigidbody = GetComponent<Rigidbody2D>(); }


    // Update is called once per frame
    /*
    void Update() {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f) {

            //print(HorizontalInput);
        } } */


    /// <summary>
    /// HorizontalMovement handles the input from the player and translates it to movement for the object
    /// </summary>
    /// <param name="horizontalInput"> The float value +/- X value for horizontal movement </param>
    public void HorizontalMovement (float horizontalInput)
    {       
            // Add force to rigidbody in the direction speed of horizontalInput and playerSpeed
            Vector2 forceToAdd = Vector2.right * horizontalInput * playerSpeed * Time.deltaTime;
            ourRigidbody.AddForce(forceToAdd);
    }
}
