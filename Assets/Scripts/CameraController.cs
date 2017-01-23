using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    // this is after the player has moved
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

    }
}
