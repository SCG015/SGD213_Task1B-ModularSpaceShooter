using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public interface IEngine
{ 
    /// <summary>
    /// Our IEngine move method. Will be used to move
    /// objects that have the IEngine interface
    /// </summary>
    /// <param name="direction">The direction of movement</param>
    public void Move(Vector3 direction);
}
