using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerController playerController = other.gameObject.GetComponent<PlayerController>();

        if(playerController != null)
        {
            Debug.Log("You lose");
            playerController.SetSpeed(0.0f);
            other.attachedRigidbody.drag = 100;
        }
        else
        {
            Debug.LogError("Null Reference PlayerController");
        }
    }
}
