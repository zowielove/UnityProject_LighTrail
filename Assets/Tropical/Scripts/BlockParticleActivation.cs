using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockParticleActivation : MonoBehaviour
{
    public ParticleSystem particleSystem; // ��ƼŬ �ý����� Unity Inspector���� �Ҵ��� �� �ֵ��� public���� �����մϴ�.

    private void OnTriggerEnter(Collider other)
    {
        // ĳ���� �Ǵ� �÷��̾ ��ϰ� �浹���� �� �ߵ��մϴ�.
        if (other.CompareTag("Player")) // "Player"�� ĳ���� �Ǵ� �÷��̾��� �±��Դϴ�. �ʿ信 ���� �±׸� �����ϼ���.
        {
            // ��ƼŬ �ý����� Ȱ��ȭ�մϴ�.
            if (particleSystem != null)
            {
                particleSystem.Play();
            }
            else
            {
                Debug.LogError("��ƼŬ �ý����� �Ҵ���� �ʾҽ��ϴ�!"); // ���� �޽����� ����մϴ�.
            }
        }
    }
}

