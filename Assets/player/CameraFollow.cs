using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTransform;
    public float smoothSpeed = 0.125f;
    //Följer spelaren - Vincent
    void FixedUpdate()
    {
        Vector3 desiredPosition = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
