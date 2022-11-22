using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Obstacle"))
        {

            if (other.gameObject.GetComponent<ObstacleStatus>().canBlock)
            {
                GameObject.FindObjectOfType<StackController>().RemoveCube(this.gameObject);
            }
            
            other.gameObject.GetComponent<ObstacleStatus>().DisableBlock();
        }
    }
}
