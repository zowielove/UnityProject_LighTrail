using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReStart : MonoBehaviour
{
    public void GameSceneLoad()
    {
        Debug.Log("불러올게");
        StartCoroutine(LoadGameScene());
    }

    public IEnumerator LoadGameScene()
    {
        Debug.Log("기다려");
        yield return new WaitForSecondsRealtime(1.5f);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Test_KM");

    }
}
