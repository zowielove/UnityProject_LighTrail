using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed; // ȸ�� �ӵ�

    void Update()
    {
        // ������Ʈ�� z�� ������ ȸ����Ű��
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
