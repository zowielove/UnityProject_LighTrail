using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReStart : MonoBehaviour
{
    [SerializeField] string Track_Name;
    public void GameSceneLoad()
    {
        StartCoroutine(LoadGameScene());
    }

    public IEnumerator LoadGameScene()
    {

        yield return new WaitForSecondsRealtime(1.5f);

        UnityEngine.SceneManagement.SceneManager.LoadScene($"{Track_Name}");

    }
}
