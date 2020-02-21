using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        DetectionAura playerController = other.gameObject.GetComponent<DetectionAura>();

        if (playerController != null)
        {
            Debug.Log("Loooooser ^_^");
            Time.timeScale = 0f;
        }
        else
        {
            Debug.LogError("Null Reference PlayerController");
        }
    }
}
