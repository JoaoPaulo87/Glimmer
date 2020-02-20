using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionAura : MonoBehaviour
{
    private Light light;
    private SphereCollider playerCollider;
    private PlayerMovementController movementController;

    void Start()
    {
        this.light = gameObject.GetComponent<Light>();
        this.playerCollider = gameObject.GetComponent<SphereCollider>();
        this.movementController = gameObject.GetComponentInParent<PlayerMovementController>();
    }

    private void Update()
    {
        if (this.movementController != null)
        {
            Vector3 movementVector = this.movementController.GetMovementVector();

            if (Input.GetKey(KeyCode.LeftShift))
            {
                this.CrouchAura(movementVector.magnitude);
            }
            else
            {
                this.UpdateAura(movementVector.magnitude);
            }
        }
    }

    public void UpdateAura(float movementMagnitude)
    {
        this.playerCollider.radius = movementMagnitude * 2;
        this.light.range = movementMagnitude * 2;
        this.light.intensity = movementMagnitude * 20;
    }

    public void CrouchAura(float movementMagnitude)
    {
        this.playerCollider.radius = movementMagnitude;
        this.light.range = movementMagnitude;
        this.light.intensity = movementMagnitude * 5;
    }
}
