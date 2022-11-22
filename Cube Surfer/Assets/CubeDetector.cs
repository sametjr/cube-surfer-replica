using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDetector : MonoBehaviour
{
    StackController stackController;
    private void Start() {
        stackController = GameObject.FindObjectOfType<StackController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CollectableCube"))
        {
            Debug.Log("Collect Cube");
            Destroy(other.gameObject);
            stackController.AddCube();
        }

        // else if (other.CompareTag("Obstacle"))
        // {

        //     if (other.GetComponent<ObstacleStatus>().canBlock)
        //     {
        //         stackController.RemoveCube(this.transform.parent.gameObject);
        //     }
            
        //     other.GetComponent<ObstacleStatus>().DisableBlock();
        // }
        else if(other.CompareTag("Diamond"))
        {
            other.GetComponent<ParticleHandler>().Hit();
            GameManager.Instance.Score+= 10;
            Debug.Log(GameManager.Instance.Score);
        }
    }
}
