using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseUI : MonoBehaviour
{
    public GameObject pauseMenu;

    public void OnPause( InputValue value )
    {
       
            Time.timeScale = 0f; // 시간을 멈춤
            pauseMenu.SetActive(true); // 일시정지 메뉴 활성화

    }
}
