using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceUI : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    [SerializeField] GameObject del;

    private void OnTriggerEnter( Collider collision )
    {
    
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
