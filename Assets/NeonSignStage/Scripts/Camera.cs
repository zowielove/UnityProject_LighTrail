using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera camera_now;
    [SerializeField] CinemachineVirtualCamera camera_next;
    [SerializeField] LayerMask layerMask;

    private void OnTriggerEnter( Collider collision )
    {
        if ( ( layerMask.value & 1 << collision.gameObject.layer ) != 0 )
        {
            camera_now.Priority = 9;
            camera_next.Priority = 11;
        }
    }
}