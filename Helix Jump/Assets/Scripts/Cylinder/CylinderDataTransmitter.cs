using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderDataTransmitter : MonoBehaviour
{
    [SerializeField] private CylinderInputController cylinderInputController;
    [SerializeField] private CylinderRotateController cylinderRotateController;


    public Vector2 GetKeyboardInputValues() {
        return cylinderInputController.rotateDirection;
    }
}
