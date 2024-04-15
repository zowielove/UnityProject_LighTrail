using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FishFly : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] int speed;
    [SerializeField] Transform playerTransform;
    [SerializeField] float triggerDistance;     // 거리기준


    void Update()
    {
        if ( playerTransform == null )
            return;

        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        Debug.Log($"내 위치 : {transform.position}");
        Debug.Log($"플레이어 위치 : {playerTransform.position}");
        Debug.Log($"측정 거리 : {distanceToPlayer}");

        // 플레이어와 타일 사이의 거리가 일정 거리 내에 있을 때 타일 이동
        if ( distanceToPlayer < triggerDistance )
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;

            Jump();
        }
    }

    private void Jump()
    {
        animator.Play("FishFly");
    }
}

