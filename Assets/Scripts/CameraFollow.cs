using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  
  
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}