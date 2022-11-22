using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 5f;
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * Time.fixedDeltaTime * rotateSpeed);
    }
}
