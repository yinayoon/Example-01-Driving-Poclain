using System;
using UnityEngine;
using TMPro; // TextMeshPro�� ���� ���ӽ����̽�

public class CountdownGameOver : MonoBehaviour
{
    [Header("- Float")]
    public float timeLimit = 20f; // ���� �ð� (��)

    [Header("- GameObject")]
    public GameObject gameOverUI; // ���� ���� UI ����

    [Header("- GUI")]
    public TextMeshProUGUI timerText; // TextMeshPro �ؽ�Ʈ�� ���� (ī��Ʈ�ٿ� ǥ��)

    // Private
    private bool isGameOver = false; // ���� ���� ���� Ȯ�� ����

    void Start()
    {
        // ���� ���� UI ��Ȱ��ȭ
        if (gameOverUI != null) { gameOverUI.SetActive(false); }
    }

    void Update()
    {
        if (isGameOver) return; // ���� ���� ���¿����� Update() ����
                
        timeLimit -= Time.deltaTime; // ���� �ð� ����
                
        if (timerText != null) // UI�� ī��Ʈ�ٿ� ǥ��
            timerText.text = "Time Left : " + Convert.ToInt32(timeLimit) + "s";

        if (timeLimit <= 0f) // ���� �ð��� �� ���� ��
            TriggerGameOver();        
    }

    // ���� ���� ó��
    public void TriggerGameOver()
    {
        if (isGameOver)
            return; // �̹� ���� ���� �����̸� �������� ����

        isGameOver = true;
        
        if (gameOverUI != null) // ���� ���� UI Ȱ��ȭ
            gameOverUI.SetActive(true);
                
        Time.timeScale = 0; // ������ ������ �κ� ���߱�
    }

    // ���� ���� ���¸� �ܺο��� Ȯ�� ����
    public bool IsGameOver()
    {
        return isGameOver;
    }
}