using System;
using UnityEngine;
using TMPro; // TextMeshPro를 위한 네임스페이스

public class CountdownGameOver : MonoBehaviour
{
    [Header("- Float")]
    public float timeLimit = 20f; // 제한 시간 (초)

    [Header("- GameObject")]
    public GameObject gameOverUI; // 게임 오버 UI 연결

    [Header("- GUI")]
    public TextMeshProUGUI timerText; // TextMeshPro 텍스트를 연결 (카운트다운 표시)

    // Private
    private bool isGameOver = false; // 게임 오버 상태 확인 변수

    void Start()
    {
        // 게임 오버 UI 비활성화
        if (gameOverUI != null) { gameOverUI.SetActive(false); }
    }

    void Update()
    {
        if (isGameOver) return; // 게임 오버 상태에서는 Update() 중지
                
        timeLimit -= Time.deltaTime; // 제한 시간 감소
                
        if (timerText != null) // UI에 카운트다운 표시
            timerText.text = "Time Left : " + Convert.ToInt32(timeLimit) + "s";

        if (timeLimit <= 0f) // 제한 시간이 다 됐을 때
            TriggerGameOver();        
    }

    // 게임 오버 처리
    public void TriggerGameOver()
    {
        if (isGameOver)
            return; // 이미 게임 오버 상태이면 실행하지 않음

        isGameOver = true;
        
        if (gameOverUI != null) // 게임 오버 UI 활성화
            gameOverUI.SetActive(true);
                
        Time.timeScale = 0; // 게임의 나머지 부분 멈추기
    }

    // 게임 오버 상태를 외부에서 확인 가능
    public bool IsGameOver()
    {
        return isGameOver;
    }
}