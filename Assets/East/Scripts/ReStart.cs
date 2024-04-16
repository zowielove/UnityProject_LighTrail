using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReStart : MonoBehaviour
{
    public void GameSceneLoad()
    {

        StartCoroutine(LoadGameScene());
    }

    public IEnumerator LoadGameScene()
    {

        yield return new WaitForSecondsRealtime(1.5f);

        UnityEngine.SceneManagement.SceneManager.LoadScene("East");

    }
}
