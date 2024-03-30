using UnityEngine;
using System.Collections;
using System;


/// <summary>
/// Repurpose this empty script into something useful with the IEngine interface
/// Any object that needs to go only one way can use this script
/// </summary>
public class MoveForwardConstantly : MonoBehaviour
{
    // The value of direction on the Y axis. 1 is down, -1 is up
    // Value set in the editor. Prefabs have own values
    [SerializeField]
    private float directionY = 1f;
    
    private IEngine engine;

    // Use this for initialization
    void Start()
    {
        // Get a reference to our engine
        engine = GetComponent<IEngine>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set the direction of movement our engine will take
        engine.Move(Vector2.up * directionY);
    }
}
