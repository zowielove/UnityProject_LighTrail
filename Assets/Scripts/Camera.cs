using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera camera_1;
    [SerializeField] CinemachineVirtualCamera camera_2;
    [SerializeField] LayerMask layerMask;

    private void OnTriggerEnter( Collider collision )
    {
        if ( ( layerMask.value & 1 << collision.gameObject.layer ) != 0 )
        {
            camera_2.Priority = 11;
        }
    }
}
