using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseUI : MonoBehaviour
{
    public GameObject pauseMenu;

    public void OnPause( InputValue value )
    {
       
            Time.timeScale = 0f; // �ð��� ����
            pauseMenu.SetActive(true); // �Ͻ����� �޴� Ȱ��ȭ

    }
}
