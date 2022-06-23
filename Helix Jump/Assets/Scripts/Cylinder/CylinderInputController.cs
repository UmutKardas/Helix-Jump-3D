using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderInputController : MonoBehaviour
{
    public Vector2 rotateDirection;


    void Update()
    {
        HandleKeyboardInputs();
    }



    private void HandleKeyboardInputs() {
        if(Input.GetKey(KeyCode.LeftArrow)) 
        {
            rotateDirection = Vector2.left;
        }
        else if(Input.GetKey(KeyCode.RightArrow)) {
            rotateDirection = Vector2.right;
        }
        else {
            rotateDirection = Vector2.zero;
        }
    }
}
