using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRigidbodyController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;

    void Start()
    {
        sphereRigidbody = GetComponent<Rigidbody>();;
    }
}
