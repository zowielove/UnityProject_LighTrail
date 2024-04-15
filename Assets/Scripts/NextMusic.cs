using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextMusic : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void Revolvingrecord()
    {
        animator.SetTrigger("Select");
    }
}
