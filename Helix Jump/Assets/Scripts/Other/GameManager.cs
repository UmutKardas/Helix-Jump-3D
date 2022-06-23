using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text text;
    
    
    public void CheckGameState(string value, Color colorValue) {
        text.text = value;
        text.color = colorValue;
        Time.timeScale = 0;
    }
}
