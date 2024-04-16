using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseUI : MonoBehaviour
{
    [SerializeField] GameObject sureUI;
    [SerializeField] GameObject pauseUI;
    [SerializeField] AudioSource audio;
    
    public void OnPause( InputValue value )
    {
        Time.timeScale = 0f; // �ð��� ����
        pauseUI.SetActive(true); // �Ͻ����� �޴� Ȱ��ȭ
        audio.Pause();

    }

    public void Continue()
    {
        Time.timeScale = 1f; // �Ͻ����� ����
        pauseUI.SetActive(false); // �޴� ��Ȱ��ȭ
        audio.Play();
    }

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

    public void AreYouSure()
    {
        sureUI.SetActive(true);
        pauseUI.SetActive(false);
    }

    public void NoButton()
    {
        sureUI.SetActive(false);
        pauseUI.SetActive(true);
    }


}
