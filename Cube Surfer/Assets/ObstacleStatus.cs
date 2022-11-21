using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleStatus : MonoBehaviour
{
    public bool canBlock = true;

    public void DisableBlock()
    {
        canBlock = false;
    }
}
