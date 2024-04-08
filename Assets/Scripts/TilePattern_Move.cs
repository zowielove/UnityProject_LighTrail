using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePattern_Move : MonoBehaviour
{
    [SerializeField] Transform targetPosition; // 이동할 목표 위치
    [SerializeField] Transform playerTransform;
    [SerializeField] float speed; // 타일의 상승 속도
    [SerializeField] float triggerDistance; // 플레이어와 타일 사이의 거리 기준


    void Update()
    {
        if ( playerTransform == null )
            return;

        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        // 플레이어와 타일 사이의 거리가 일정 거리 내에 있을 때 타일 이동
        if ( distanceToPlayer < triggerDistance )
        {
            MoveTile();
        }
    }

    void MoveTile()
    {
        if ( Vector3.Distance(targetPosition.position, transform.position) > 0.1f )
        {
            // 목적지까지의 방향 벡터 계산
            Vector3 direction = ( targetPosition.position - transform.position ).normalized;

            // 타일을 목적지 방향으로 일정 속도로 이동
            transform.position += direction * Time.deltaTime * 3f;
        }
        else
        {
            transform.position = targetPosition.position;
        }

    }
}
