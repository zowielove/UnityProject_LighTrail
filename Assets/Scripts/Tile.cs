using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    [SerializeField] Renderer rendererToChangeMaterial;
    [SerializeField] BoxCollider collider;
    [SerializeField] Material material;
    [SerializeField] GameObject del;
    

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

        }       
    }

    private void OnTriggerExit( Collider collision )
    {

        if ( ( layerMask.value & 1 << collision.gameObject.layer ) != 0 )
        {

            if ( del != null )
            {
                del.SetActive(false);
            }
        }
    }
}

