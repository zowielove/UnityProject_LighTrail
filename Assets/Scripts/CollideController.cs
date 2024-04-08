using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TileColliderDelete : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float triggerDistance; // 플레이어와 타일 사이의 거리 기준


   [SerializeField] Collider tileCollider; // 타일의 Collider

    void Start()
    {
        tileCollider = GetComponent<Collider>(); // 타일의 Collider 컴포넌트 가져오기
    }

    void Update()
    {
        // 플레이어와의 거리 계산
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        // 플레이어와의 거리가 일정 거리 이상이면 Collider 비활성화
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
