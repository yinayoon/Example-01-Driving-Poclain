using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리 기능 사용

public class RestartGame : MonoBehaviour
{
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Space)) // 스페이스바 입력 감지
        {
            Time.timeScale = 1; // Time.timeScale을 다시 1로 설정 (게임 재개)        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 현재 씬 다시 로드
            GetCoin.coinCount = 0;
        }       
    }
}