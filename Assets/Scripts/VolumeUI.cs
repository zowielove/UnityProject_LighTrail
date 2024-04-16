using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class VolumeUI : PopUpUI
{
    [SerializeField] Slider volume_slider;
    [SerializeField] AudioMixer audioSource;


    public void MasterCon()
    {
        float sound = volume_slider.value;

        if ( sound == -40f ) Manager.Sound.mixer.SetFloat("Master", -80);
        else Manager.Sound.mixer.SetFloat("Master", sound);
    }

    public void CloseSoundUI()
    {
        Manager.UI.ClearPopUpUI();
    }
}