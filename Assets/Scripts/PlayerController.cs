using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;
    Rigidbody rb;
    CharacterController characterController;
    Animator animator;
    void Start()
    {
        animator= GetComponent<Animator>();
        characterController= GetComponent<CharacterController>();
        rb= GetComponent<Rigidbody>();

    }

    
    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = Vector3.up*jumpSpeed*Time.deltaTime;
        }
    }


}
