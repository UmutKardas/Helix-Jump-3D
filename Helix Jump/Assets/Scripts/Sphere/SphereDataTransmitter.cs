using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDataTransmitter : MonoBehaviour
{
    [SerializeField] SphereRigidbodyController sphereRigidboyController;
    [SerializeField] SphereTriggerController sphereTriggerController;

    public Rigidbody GetSphereRigidbodyValues (){
        return sphereRigidboyController.sphereRigidbody;
    }
    public bool GetSphereTriggerValues(){
        return sphereTriggerController.SphereStop;
    }




}
