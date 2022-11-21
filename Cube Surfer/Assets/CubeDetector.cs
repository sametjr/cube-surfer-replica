using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CollectableCube"))
        {
            Debug.Log("Collect Cube");
            Destroy(other.gameObject);
            GameObject.FindObjectOfType<StackController>().AddCube();
        }

        else if (other.CompareTag("Obstacle"))
        {

            if (other.GetComponent<ObstacleStatus>().canBlock)
            {
                GameObject.FindObjectOfType<StackController>().RemoveCube(this.transform.parent.gameObject);
            }
            
            other.GetComponent<ObstacleStatus>().DisableBlock();
        }
    }
}
