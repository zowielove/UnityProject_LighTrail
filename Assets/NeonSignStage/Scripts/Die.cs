using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Die : MonoBehaviour
{
    [SerializeField] LayerMask damageCheck;
    [SerializeField] GameObject DieEffect;
    [SerializeField] AudioClip audioDie;
    [SerializeField] AudioSource BGM;

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
            BGM.mute = true;
            Manager.Sound.PlaySFX(audioDie);
            Died();
        }
    }
}
