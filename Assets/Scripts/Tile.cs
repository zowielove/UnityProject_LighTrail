using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    [SerializeField] Renderer rendererToChangeMaterial;
    [SerializeField] BoxCollider collder;
    [SerializeField] Material material;

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
        }
    }

    private void OnTriggerExit( Collider collision )
    {

    }
}
