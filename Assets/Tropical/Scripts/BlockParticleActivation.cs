using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockParticleActivation : MonoBehaviour
{
    public ParticleSystem particleSystem; // 파티클 시스템을 Unity Inspector에서 할당할 수 있도록 public으로 선언합니다.

    private void OnTriggerEnter(Collider other)
    {
        // 캐릭터 또는 플레이어가 블록과 충돌했을 때 발동합니다.
        if (other.CompareTag("Player")) // "Player"는 캐릭터 또는 플레이어의 태그입니다. 필요에 따라 태그를 변경하세요.
        {
            // 파티클 시스템을 활성화합니다.
            if (particleSystem != null)
            {
                particleSystem.Play();
            }
            else
            {
                Debug.LogError("파티클 시스템이 할당되지 않았습니다!"); // 오류 메시지를 출력합니다.
            }
        }
    }
}

