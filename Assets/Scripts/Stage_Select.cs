using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Select : MonoBehaviour
{
    [SerializeField] AudioClip select;

    [Header("Track")]
    [SerializeField] string stage1;
    [SerializeField] string stage2;
    [SerializeField] string stage3;
    [SerializeField] string stage4;
    [SerializeField] string stage5;

    public void Stage1_SceneLoad()
    {
        Manager.Scene.LoadScene($"{stage1}");
    }

    public void Stage2_SceneLoad()
    {
        Manager.Scene.LoadScene($"{stage2}");
    }

    public void Stage3_SceneLoad()
    {
        Manager.Scene.LoadScene($"{stage3}");
    }

    public void Stage4_SceneLoad()
    {
        Manager.Scene.LoadScene($"{stage4}");
    }

    public void Stage5_SceneLoad()
    {
        Manager.Scene.LoadScene($"{stage5}");
    }

    public void selectTrack()
    {
        Manager.Sound.PlaySFX(select);
    }
}
