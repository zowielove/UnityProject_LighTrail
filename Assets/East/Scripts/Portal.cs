using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] LayerMask playerMask;
    [SerializeField] Transform targetlocation;


    private void OnTriggerEnter( Collider collision )
    {
        if ( collision.gameObject == player )
        {
            player.transform.position = targetlocation.position;
            player.transform.rotation = targetlocation.rotation;
        }
    }
}
