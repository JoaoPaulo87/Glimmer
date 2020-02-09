using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;              
    private Rigidbody playerRB;  

    void Start()
    {
        this.playerRB = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        playerRB.AddForce(movement * speed);
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }
}
