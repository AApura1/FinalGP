using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
   
        void Start()
        {
            // Get the Rigidbody component
            Rigidbody rb = GetComponent<Rigidbody>();

            // Check if the Rigidbody component exists
            if (rb != null)
            {
                // Set the collision detection mode to Continuous
                rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
            }
            else
            {
                Debug.LogError("Rigidbody component not found!");
            }
        }
    
}