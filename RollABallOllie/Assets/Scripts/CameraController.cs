using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;
    public Vector3 posOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + posOffset;
    }
}
