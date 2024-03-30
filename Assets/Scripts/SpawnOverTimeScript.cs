using UnityEngine;
using System.Collections;


/// <summary>
/// Handles the when and where of spawning of objects into the game
/// </summary>
public class SpawnOverTimeScript : MonoBehaviour
{
    // Object to spawn
    [SerializeField]
    private GameObject spawnObject;

    // Delay between spawns
    [SerializeField]
    private float spawnDelay = 2f;

    private Renderer ourRenderer;

    // Use this for initialization
    void Start()
    {
        // Get and store a reference to the renderer
        ourRenderer = GetComponent<Renderer>();

        // Stop our Spawner from being visible!
        ourRenderer.enabled = false;

        // Call the given function after spawnDelay seconds, 
        // and then repeatedly call it after spawnDelay seconds.
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    /// <summary>
    /// Spawn will create an enemy object at a random point between the minimum and maximum SpawnRanges
    /// It finds those values by taking the value of the bounds, halving it then +/- each half to the transform
    /// </summary>
    void Spawn()
    {
        // Set the spawnrange values. Calculates the ranges based on the spawner position and renderer size
        float minimumSpawnRange = transform.position.x - ourRenderer.bounds.size.x / 2;
        float maximumSpawnRange = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawnRange
        Vector2 spawnPoint = new Vector2(Random.Range(minimumSpawnRange, maximumSpawnRange), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
