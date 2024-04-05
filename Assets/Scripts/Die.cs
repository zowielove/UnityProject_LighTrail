using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Die : MonoBehaviour
{
    [SerializeField] LayerMask damageCheck;
    [SerializeField] GameObject DieEffect;
    [SerializeField] AudioSource audio;

    [Header("Events")]
    public UnityEvent OnDied;


    private void Died()
    {
        GameObject deathEffect = Instantiate(DieEffect, transform.position, Quaternion.identity);

        OnDied?.Invoke();
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
