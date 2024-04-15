using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePattern_Move : MonoBehaviour
{
    [SerializeField] Transform targetPosition; // �̵��� ��ǥ ��ġ
    [SerializeField] Transform playerTransform;
    [SerializeField] float speed; // Ÿ���� ��� �ӵ�
    [SerializeField] float triggerDistance; // �÷��̾�� Ÿ�� ������ �Ÿ� ����


    void Update()
    {
        if ( playerTransform == null )
            return;

        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        // �÷��̾�� Ÿ�� ������ �Ÿ��� ���� �Ÿ� ���� ���� �� Ÿ�� �̵�
        if ( distanceToPlayer < triggerDistance )
        {
            MoveTile();
        }
    }

    void MoveTile()
    {
        if ( Vector3.Distance(targetPosition.position, transform.position) > 0.1f )
        {
            // ������������ ���� ���� ���
            Vector3 direction = ( targetPosition.position - transform.position ).normalized;

            // Ÿ���� ������ �������� ���� �ӵ��� �̵�
            transform.position += direction * Time.deltaTime * 3f;
        }
        else
        {
            transform.position = targetPosition.position;
        }

    }
}
