using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    [SerializeField] RectTransform scroll;
    [SerializeField] int move;
       

    public void Exit()
    {
        StartCoroutine(ExitCount());
    }

    public void LeftArrow()
    {
        if ( scroll != null )
        {
            Debug.Log("왼쪽 무빙");
            Debug.Log($"{scroll.anchoredPosition}");
            Vector2 newPosition = scroll.anchoredPosition + Vector2.right * move; // Calculate new position
            scroll.anchoredPosition = newPosition; // Apply new position to the scroll
            
        }
    }

    public void RightArrow()
    {
        if ( scroll != null )
        {
            Debug.Log("오른쪽 무빙");
            Debug.Log($"{scroll.anchoredPosition}");
            Vector2 newPosition = scroll.anchoredPosition + Vector2.left * move; // Calculate new position
            scroll.anchoredPosition = newPosition; // Apply new position to the scroll
        }        
    }


    private IEnumerator ExitCount()
    {
        yield return new WaitForSeconds(1.5f);
        Application.Quit();
        Debug.Log("게임종료 확인");
    }
}