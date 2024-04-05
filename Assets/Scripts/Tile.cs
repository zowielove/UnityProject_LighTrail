using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    [SerializeField] Renderer rendererToChangeMaterial;
    [SerializeField] BoxCollider collider;
    [SerializeField] Material material;
    

    private Vector3 initialColliderPosition;

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
                collider.size = new Vector3(5f , 0.5f, 5f);
        }       
    }

    private void OnTriggerExit( Collider collision )
    {

    }

}

