using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarWorldSpaceController : MonoBehaviour
{
    public Transform playerCamera;

    void Start()
    {
        GameObject pCam = GameObject.Find("PlayerCamera");
        if (pCam)
        {
            playerCamera = pCam.transform;
        }
    }


    void LateUpdate()
    {
        // billboard the healthBar
        if (playerCamera)
        {
            transform.LookAt(transform.position + playerCamera.forward);
        }
    }
}
