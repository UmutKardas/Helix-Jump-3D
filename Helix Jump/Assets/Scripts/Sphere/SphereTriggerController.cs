using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTriggerController : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    [SerializeField] private SphereDataTransmitter sphereDataTransmitter;
    public float sphereJumpSpeed;
    public bool SphereStop= false;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Safe"))
        {
            sphereDataTransmitter.GetSphereRigidbodyValues().velocity = Vector3.up * sphereJumpSpeed * Time.deltaTime;
        }


        if (other.gameObject.CompareTag("Unsafe"))
        {
            gameManager.CheckGameState("GAME OVER", Color.red);
        }


        if (other.gameObject.CompareTag("Finish"))
        {
            gameManager.CheckGameState("GAME WON", Color.yellow);
        }
    }
   
}
