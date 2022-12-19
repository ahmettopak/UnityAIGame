using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;

    CharacterController characterController;
    Animator animator;
    void Start()
    {
        animator= GetComponent<Animator>();
        characterController= GetComponent<CharacterController>();

    }

    
    void Update()
    {
            Debug.Log("sdc");
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

        // Move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);
    }
}
