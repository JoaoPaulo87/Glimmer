﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody playerRigidbody;
    private Vector3 movementVector;

    private void Start()
    {
        this.playerRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        this.MovePlayer();
    }
    
    public Vector3 GetMovementVector()
    {
        return this.movementVector;
    }

    private void MovePlayer()
    {
        this.movementVector = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        this.playerRigidbody.AddForce(this.movementVector * this.speed);
    }
}