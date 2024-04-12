using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] LayerMask playerCheck;
    [SerializeField] Transform targetlocation;
    [SerializeField] Animator animator;

    private bool speedUp;
    private int playerCount;

    private void Update()
    {
        if( speedUp == true )
        {
            player.transform.position = targetlocation.position;
        }
    }

    private void OnTriggerEnter( Collider other )
    {
        if ( playerCheck.Contain(other.gameObject.layer) )
        {
            speedUp = true;
            playerCount++;
            speedUp = playerCount > 0;
            Player playerScript = other.GetComponent<Player>();            
            playerScript.playerSpeed = 0;
            if( playerScript.playerSpeed ==0)
            {
                animator.SetBool("Goal", true);
            }            
        }
    }
}
