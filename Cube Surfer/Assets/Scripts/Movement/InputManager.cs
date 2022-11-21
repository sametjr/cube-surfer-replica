using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private int screenWidth;
    private float lastPosition, movement;
    public float Movement => this.movement;
    private void Start() {
        screenWidth = Screen.width;
    }
    private void Update() {
        if(Input.GetMouseButtonDown(0))
        {
            lastPosition = Input.mousePosition.x;
        }
        if(Input.GetMouseButton(0))
        {
            movement = Input.mousePosition.x - lastPosition;
            
            lastPosition = Input.mousePosition.x;
        }
        if(Input.GetMouseButtonUp(0))
        {
            movement = 0f;
        }
    }
}
