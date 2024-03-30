using UnityEngine;
using System.Collections;


/// <summary>
/// Handles the shooting function 
/// </summary>
public class ShootingScript : MonoBehaviour
{
    // Reference for our bullet game object to populate
    [SerializeField]
    private GameObject bullet;

    // Value for Time between firing shots
    [SerializeField]
    private float fireDelay = 1f;

    // Value since last time fired
    private float lastFiredTime = 0f;
    // Default value for bulletOffset
    private float bulletOffset = 2f;

    // Use this for initialization
    void Start()
    {
        // Do some math to perfectly spawn bullets in front of us
        // Half of our size plus half of the bullet size
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2
            + bullet.GetComponent<Renderer>().bounds.size.y / 2;
    }

    /// <summary>
    /// Shoot method to spawn a bullet from the middle of our spaceship object.
    /// fireDelay has been implemetned to prevent player from spamming the bullet
    /// </summary>
    public void Shoot()
    {
        // Store value of the current time
        float currentTime = Time.time;

        // If the time since last run is greater than our delay value
        if (currentTime - lastFiredTime > fireDelay)
        {
            // Spawn bullet at the bulletOffset calculated previously
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
            //
            Instantiate(bullet, spawnPosition, transform.rotation);
            // Set lastFiredTime to the current time value to be compared for the next run
            lastFiredTime = currentTime;
        }
    }
}