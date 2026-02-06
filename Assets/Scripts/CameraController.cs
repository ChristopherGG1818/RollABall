using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;  // Fixed capitalization
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after all Update function
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;  // Fixed missing dot
    }
}
