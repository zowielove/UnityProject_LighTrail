using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageCamera : MonoBehaviour
{
   
        void Update()
        {
            // ���� ī�޶��� ��ġ�� ����ϴ�.
            Transform cameraTransform = Camera.main.transform;

            // �̹����� ī�޶� ���ϵ��� ȸ���մϴ�.
            transform.LookAt(transform.position + cameraTransform.rotation * Vector3.forward,
                             cameraTransform.rotation * Vector3.up);
        }
    
}
