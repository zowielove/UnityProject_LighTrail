using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSceneChange : MonoBehaviour
{   
    [SerializeField] Animator m_Animator;
    [SerializeField] string scene_Name;

    void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }
    public void OnEnterNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene($"{scene_Name}");
    }
}
