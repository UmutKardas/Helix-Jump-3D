using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotateController : MonoBehaviour
{
    [SerializeField] private CylinderDataTransmitter cylinderDataTransmitter;
    [SerializeField] private float rotateSpeed;


    private void Update() {
        RotateCylinder();
    }


    private void RotateCylinder() {
        transform.Rotate(0f, cylinderDataTransmitter.GetKeyboardInputValues().x * rotateSpeed * Time.deltaTime, 0f);
    }
}
