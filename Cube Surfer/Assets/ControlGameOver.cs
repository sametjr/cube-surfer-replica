using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Ground"))
        {
            // Debug.Log("Game Over!");
        }
    }
}
