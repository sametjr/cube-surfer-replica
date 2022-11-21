using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float horizontalSpeed = 1f, verticalSpeed = 1f;
    private void Update()
    {
        if (transform.position.x - (GameManager.Instance.cubeWidth / 2) + (Vector3.right * inputManager.Movement * Time.deltaTime * horizontalSpeed).x < GameManager.Instance.floorXBounds[0]
        || transform.position.x + (GameManager.Instance.cubeWidth / 2) + (Vector3.right * inputManager.Movement * Time.deltaTime * horizontalSpeed).x > GameManager.Instance.floorXBounds[1])
        { }
        else
        {

            transform.Translate(Vector3.right * inputManager.Movement * Time.deltaTime * horizontalSpeed);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed);
    }
}
