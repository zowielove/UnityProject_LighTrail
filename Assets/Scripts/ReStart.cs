using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReStart : MonoBehaviour
{
    public void GameSceneLoad()
    {
        Debug.Log("�ҷ��ð�");
        StartCoroutine(LoadGameScene());
    }

    public IEnumerator LoadGameScene()
    {
        Debug.Log("��ٷ�");
        yield return new WaitForSecondsRealtime(1.5f);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Test_KM");

    }
}
