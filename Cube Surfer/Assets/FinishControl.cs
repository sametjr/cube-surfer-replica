using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Cube"))
        {
            FindObjectOfType<UIControl>().LevelPassed();
        }
    }
}
