using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    [SerializeField] Renderer rendererToChangeMaterial;
    [SerializeField] BoxCollider collider;
    [SerializeField] Material material;


    private Vector3 initialColliderSize;

    public bool play;


    private void OnTriggerEnter( Collider collision )
    {
        if ( ( layerMask.value & 1 << collision.gameObject.layer ) != 0 )
        {

            play = true;
            if ( rendererToChangeMaterial != null && material != null )
            {
                rendererToChangeMaterial.material = material;
            }
           // collider.size = new Vector3(5f, 0.5f, 5f);
        }
    }

    private void OnTriggerExit( Collider other )
    {
       /* if ( ( ( 1 << other.gameObject.layer ) & layerMask.value ) != 0 )
        {
            // 타일이 플레이어와 충돌을 빠져나갈 때 동작

            // 콜라이더 크기를 초기 크기로 되돌림
            collider.size = initialColliderSize;
        } */
    } 
}
