using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageCamera : MonoBehaviour
{
   
        void Update()
        {
            // 메인 카메라의 위치를 얻습니다.
            Transform cameraTransform = Camera.main.transform;

            // 이미지가 카메라를 향하도록 회전합니다.
            transform.LookAt(transform.position + cameraTransform.rotation * Vector3.forward,
                             cameraTransform.rotation * Vector3.up);
        }
    
}
