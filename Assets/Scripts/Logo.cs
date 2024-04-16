using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo : MonoBehaviour
{
    
    [SerializeField] Animator m_Animator;

    void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }
    public void OnEnterNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("02.StageSelect");
    }
}
