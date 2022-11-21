using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset;
    [SerializeField] private float lerpValue;

    private void Start() {
        offset = GameManager.Instance.player.transform.position - transform.position;
    }
    private void LateUpdate() {
        transform.position = Vector3.Lerp(transform.position, GameManager.Instance.player.transform.position - offset, lerpValue * Time.deltaTime);
    }
}
