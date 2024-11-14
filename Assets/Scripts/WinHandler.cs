using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHandler : MonoBehaviour
{
    [Header("- GameObject")]
    public GameObject winUI;   // �¸� UI ����

    [Header("- LayerMask")]
    public LayerMask winLayer;  // "Win" ���̾� ����
    
    // Private
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSource ������Ʈ �ʱ�ȭ

        if (winUI != null) { winUI.SetActive(false); } // �¸� UI ��Ȱ��ȭ
    }

    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ������Ʈ�� "Win" ���̾ ���ϴ��� Ȯ��
        if (other.gameObject.layer == LayerMask.NameToLayer("Win"))
        {
            // �÷��̾� �̵� ���߱�
            PlayerController playerController = GetComponent<PlayerController>();
            if (playerController != null) { playerController.enabled = false; }
            
            if (winUI != null) { winUI.SetActive(true); } // �¸� UI Ȱ��ȭ            
            if (audioSource != null) { audioSource.Stop(); } // ����� ����            
            Time.timeScale = 0; // ������ ������ �κ� ����
        }
    }
}