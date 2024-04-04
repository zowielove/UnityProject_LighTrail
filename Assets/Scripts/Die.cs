using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] LayerMask damageCheck;
    [SerializeField] GameObject DieEffect;
    [SerializeField] AudioSource audio;

    private void Died()
    {
        GameObject deathEffect = Instantiate(DieEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnTriggerEnter( Collider collision )
    {
        if ( ( damageCheck.value & 1 << collision.gameObject.layer ) != 0 )
        {
            Debug.Log("��Ҵ�");
            //audio.Play();
            Died();
        }
    }
}
