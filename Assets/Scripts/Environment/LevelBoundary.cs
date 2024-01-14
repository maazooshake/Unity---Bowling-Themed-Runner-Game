using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -2f; // static means all the scripts can interact with this variable
    public static float rightSide = 2f;
    public float internalLeft;
    public float internalRight;

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide; 
    }
}
