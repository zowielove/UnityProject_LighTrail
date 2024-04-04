using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour
{
    [SerializeField] AudioClip BGM;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if ( audioSource == null )
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // BGM ¼³Á¤
        audioSource.clip = BGM;
        audioSource.loop = true;
    }

    private void OnTriggerEnter( Collider other )
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }
}
