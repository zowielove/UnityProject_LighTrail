using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed; // 회전 속도

    void Update()
    {
        // 오브젝트를 z축 주위로 회전시키기
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
