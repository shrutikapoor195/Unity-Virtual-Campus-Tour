using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera ThirdPersonCamera;
    public Camera FirstPersonCamera;

    void Start()
    {
        ThirdPersonCamera.enabled = true;
        FirstPersonCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            ThirdPersonCamera.enabled = true;
            FirstPersonCamera.enabled = false;
        }
        if (Input.GetKeyDown("f"))
        {
            FirstPersonCamera.enabled = true;
            ThirdPersonCamera.enabled = false;
        }
    }
}
