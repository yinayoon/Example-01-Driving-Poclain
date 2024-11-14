using UnityEngine;
using TMPro; // TextMeshPro ���ӽ����̽� �߰�

public class CoinUIManager : MonoBehaviour
{
    public TextMeshProUGUI coinText; // TMP �ؽ�Ʈ ������Ʈ ����

    void Update()
    {
        // UI �ؽ�Ʈ�� ���� ���� ���� ������Ʈ
        coinText.text = GetCoin.coinCount.ToString();
    }
}