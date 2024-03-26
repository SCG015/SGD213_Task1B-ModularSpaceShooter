using UnityEngine;
using System.Collections;


/// <summary>
/// 
/// </summary>
public class ShootingScript : MonoBehaviour
{
    // reference for our bullet game object to populate
    [SerializeField]
    private GameObject bullet;

    // Value for Time between firing shots
    [SerializeField]
    private float fireDelay = 1f;
    private float lastFiredTime = 0f;
    private float bulletOffset = 2f;

    // Use this for initialization
    void Start()
    {
        // Do some math to perfectly spawn bullets in front of us
        // Half of our size plus half of the bullet size
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2
            + bullet.GetComponent<Renderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            float CurrentTime = Time.time;

            // Have a delay so we don't shoot too many bullets
            if (CurrentTime - lastFiredTime > fireDelay)
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);

                Instantiate(bullet, spawnPosition, transform.rotation);

                lastFiredTime = CurrentTime;
            }

            //print("Shoot!");
        }
    }*/

    /// <summary>
    /// Shoot method to spawn a bullet from the middle of our spaceship object.
    /// fireDelay has been implemetned to prevent player from spamming the bullet
    /// </summary>
    public void Shoot()
    {
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