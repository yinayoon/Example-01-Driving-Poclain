using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHandler : MonoBehaviour
{
    [Header("- GameObject")]
    public GameObject winUI;   // 승리 UI 연결

    [Header("- LayerMask")]
    public LayerMask winLayer;  // "Win" 레이어 설정
    
    // Private
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSource 컴포넌트 초기화

        if (winUI != null) { winUI.SetActive(false); } // 승리 UI 비활성화
    }

    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 오브젝트가 "Win" 레이어에 속하는지 확인
        if (other.gameObject.layer == LayerMask.NameToLayer("Win"))
        {
            // 플레이어 이동 멈추기
            PlayerController playerController = GetComponent<PlayerController>();
            if (playerController != null) { playerController.enabled = false; }
            
            if (winUI != null) { winUI.SetActive(true); } // 승리 UI 활성화            
            if (audioSource != null) { audioSource.Stop(); } // 오디오 정지            
            Time.timeScale = 0; // 게임의 나머지 부분 멈춤
        }
    }
}