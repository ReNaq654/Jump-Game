using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField] private float jumpHeight = 7f;

    [SerializeField] private float rightSpeed = 10f;

    public AudioSource jumpSound;

    //Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * rightSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            jumpSound.Play();
            rb.velocity = new Vector3(5f, jumpHeight, 0);
        }
    }
} 
