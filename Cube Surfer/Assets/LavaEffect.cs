using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaEffect : MonoBehaviour
{
    private bool shouldEffect = false;
    private StackController stackController;
    private GameObject removableCube;
    private void Start()
    {
        stackController = GameObject.FindObjectOfType<StackController>();
        StartCoroutine(Melt());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            shouldEffect = true;
            removableCube = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            shouldEffect = false;
        }
    }

    private IEnumerator Melt()
    {
        while (true)
        {
            if (shouldEffect)
            {
                stackController.RemoveCube(removableCube);

            }
            yield return new WaitForSecondsRealtime(.5f);
        }
    }
}
