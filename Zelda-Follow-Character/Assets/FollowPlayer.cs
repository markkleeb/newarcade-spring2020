using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    private void FixedUpdate()
    {
        //Grab our target's position
        Vector3 targetPos = target.position;

        //Lock Z position of camera to player
        targetPos.z = transform.position.z;

        //Smoothly transition from Point A to Point B
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);



    }

}
