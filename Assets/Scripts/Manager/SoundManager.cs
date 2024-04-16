using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : Singleton<SoundManager>
{

    public AudioMixer mixer;

    [SerializeField] AudioSource bgmSource;
    [SerializeField] AudioSource sfxSource;

    public float BGMVolme { get { return bgmSource.volume; } set { bgmSource.volume = value; } }
    public float SFXVolme { get { return sfxSource.volume; } set { sfxSource.volume = value; } }

    public void PlayBGM(AudioClip clip)
    {
        if (bgmSource.isPlaying)
        {
            bgmSource.Stop();
        }
        bgmSource.clip = clip;
        bgmSource.Play();
    }

    public void StopBGM()
    {
        if (bgmSource.isPlaying == false)
            return;

        bgmSource.Stop();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void StopSFX()
    {
        if (sfxSource.isPlaying == false)
            return;

        sfxSource.Stop();
    }
}
