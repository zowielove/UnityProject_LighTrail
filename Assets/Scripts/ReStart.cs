using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReStart : MonoBehaviour
{
    [SerializeField] GameObject clickUI;
    public void GameSceneLoad()
    {

        StartCoroutine(LoadGameScene());

        clickUI.SetActive(true);

    }

    public IEnumerator LoadGameScene()
    {

        yield return new WaitForSecondsRealtime(1.5f);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Test_KM");

    }
}
