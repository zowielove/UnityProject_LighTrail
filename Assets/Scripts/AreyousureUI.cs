using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreyousureUI : MonoBehaviour
{
    public GameObject sureUI;
        public IEnumerator LoadingRoutine()
        {
            // 1.5���� �ð� ��
            yield return new WaitForSecondsRealtime(1.5f);
            LobbySceneLoad();
        }


        public void LobbySceneLoad()
        {
            Manager.Scene.LoadScene("02.StageSelect");
        }

    public void NoButton()
    {

    }
}
