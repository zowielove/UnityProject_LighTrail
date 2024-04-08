using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TileColliderDelete : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float triggerDistance; // �÷��̾�� Ÿ�� ������ �Ÿ� ����


   [SerializeField] Collider tileCollider; // Ÿ���� Collider

    void Start()
    {
        tileCollider = GetComponent<Collider>(); // Ÿ���� Collider ������Ʈ ��������
    }

    void Update()
    {
        // �÷��̾���� �Ÿ� ���
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        // �÷��̾���� �Ÿ��� ���� �Ÿ� �̻��̸� Collider ��Ȱ��ȭ
        if ( distanceToPlayer > triggerDistance )
        {
            tileCollider.enabled = false;
        }
        else
        {
            tileCollider.enabled = true;
        }
    }
}
