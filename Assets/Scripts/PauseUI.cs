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
        Time.timeScale = 0f; // 시간을 멈춤
        pauseUI.SetActive(true); // 일시정지 메뉴 활성화
        audio.Pause();

    }

    public void Continue()
    {
        Time.timeScale = 1f; // 일시정지 해제
        pauseUI.SetActive(false); // 메뉴 비활성화
        audio.Play();
    }

    public IEnumerator LoadingRoutine()
    {
        // 1.5초의 시간 후
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
