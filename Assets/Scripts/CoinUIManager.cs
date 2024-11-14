using UnityEngine;
using TMPro; // TextMeshPro 네임스페이스 추가

public class CoinUIManager : MonoBehaviour
{
    public TextMeshProUGUI coinText; // TMP 텍스트 컴포넌트 연결

    void Update()
    {
        // UI 텍스트에 현재 코인 개수 업데이트
        coinText.text = GetCoin.coinCount.ToString();
    }
}