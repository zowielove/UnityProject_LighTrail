using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerDistance : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float speed; // 속도
    [SerializeField] float triggerDistance; // 플레이어와 거리 각격

    [SerializeField] LayerMask layerMask;
    [SerializeField] Animation animation;
    [SerializeField] Material material;
    [SerializeField] AudioClip audio;
    [SerializeField] GameObject Effect;
    [SerializeField] Renderer rendererToChangeMaterial;

    private Vector3 initialColliderSize;

    public bool play;
    void Update()
    {
        if ( playerTransform == null )
            return;

        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        // 플레이어와 타일 사이의 거리가 일정 거리 내에 있을 때 작동
        if ( distanceToPlayer < triggerDistance )
        {
            Play();
        }
    }

    private void Play()
    {

    }
    private void OnTriggerEnter( Collider collision )
    {
        if ( ( layerMask.value & 1 << collision.gameObject.layer ) != 0 )
        {

            play = true;
            if ( rendererToChangeMaterial != null && material != null )
            {
                rendererToChangeMaterial.material = material;
            }

        }
    }

    private void OnTriggerExit( Collider other )
    {

    }
}
