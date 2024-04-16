using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title2 : MonoBehaviour
{
    [SerializeField] Animator animator;


    public void SceneLoad()
    {
        Manager.Scene.LoadScene("02.StageSelect");
    }

    public void Onani()
    {
        animator.SetBool("Touch",true);
    }
}
