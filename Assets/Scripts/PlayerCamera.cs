﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    public float smootheSpeed = 0.125f;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
         Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smootheSpeed);

        transform.position = smoothedPosition;
     
    }

}
