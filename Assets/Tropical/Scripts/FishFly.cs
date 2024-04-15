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
    [SerializeField] float triggerDistance;     // �Ÿ�����


    void Update()
    {
        if ( playerTransform == null )
            return;

        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        Debug.Log($"�� ��ġ : {transform.position}");
        Debug.Log($"�÷��̾� ��ġ : {playerTransform.position}");
        Debug.Log($"���� �Ÿ� : {distanceToPlayer}");

        // �÷��̾�� Ÿ�� ������ �Ÿ��� ���� �Ÿ� ���� ���� �� Ÿ�� �̵�
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

