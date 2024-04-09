using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChange : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float moveSpeed;
    [SerializeField] LayerMask playerCheck;

    private bool speedUp;
    private int playerCount;

    private void OnTriggerEnter( Collider collision )
    {
        if ( playerCheck.Contain(collision.gameObject.layer) )
        {
            speedUp = true;
            playerCount++;
            speedUp = playerCount > 0;
            if ( speedUp )
            {
                Player playerScript = collision.GetComponent<Player>();
                if ( playerScript != null )
                {
                    playerScript.additionalSpeed = moveSpeed;                }
            }
        }
    }

    private void OnTriggerExit( Collider collision )
    {
        if ( playerCheck.Contain(collision.gameObject.layer) )
        {
            speedUp = false;
            playerCount--;
            speedUp = playerCount > 0;
            if ( speedUp )
            {
                Player playerScript = collision.GetComponent<Player>();
                if ( playerScript != null )
                {
                    playerScript.additionalSpeed = 0;
                }
            }
        }
    }
}
