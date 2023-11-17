using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 5f;
    public Camera playerCamera;

    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
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


    private void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("IsForward", true);
        }
        else
        {
            animator.SetBool("IsForward", false);
        }

        if (Input.GetKey("a"))
        {
            animator.SetBool("IsLeft", true);
        }
        else
        {
            animator.SetBool("IsLeft", false);
        }

        if (Input.GetKey("s"))
        {
            animator.SetBool("IsBack", true);
        }
        else
        {
            animator.SetBool("IsBack", false);
        }

        if (Input.GetKey("d"))
        {
            animator.SetBool("IsRight", true);
        }
        else
        {
            animator.SetBool("IsRight", false);
        }
    }
}