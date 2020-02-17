using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody playerRB;
    private Light light;
    private bool isMoving;

    void Start()
    {
        this.playerRB = gameObject.GetComponent<Rigidbody>();
        this.light = gameObject.GetComponent<Light>();
        this.isMoving = false;
    }

    void FixedUpdate()
    {
        this.PlayerMove();
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void PlayerMove()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        this.playerRB.AddForce(movement * speed);

        PlayerMoveEffect(moveHorizontal, moveVertical);
    }

    public void PlayerMoveEffect(float moveHorizontal, float moveVertical)
    {
        if (moveHorizontal != 0 || moveVertical != 0)
        {
            this.isMoving = true;

            if (this.light.range < 2)
            {
                this.light.intensity += 0.2f * Time.timeScale;
                this.light.range += 0.1f * Time.timeScale;
            }

            this.isMoving = false;
        }
        else if (this.isMoving == false)
        {
            this.light.intensity -= 0.15f * Time.timeScale;
            this.light.range -= 0.15f * Time.timeScale;
        }
    }
}
