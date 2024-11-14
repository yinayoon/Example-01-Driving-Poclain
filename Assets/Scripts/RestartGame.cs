using UnityEngine;
using UnityEngine.SceneManagement; // �� ���� ��� ���

public class RestartGame : MonoBehaviour
{
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Space)) // �����̽��� �Է� ����
        {
            Time.timeScale = 1; // Time.timeScale�� �ٽ� 1�� ���� (���� �簳)        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ���� �� �ٽ� �ε�
            GetCoin.coinCount = 0;
        }       
    }
}