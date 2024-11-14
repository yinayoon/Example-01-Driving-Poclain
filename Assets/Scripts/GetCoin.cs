using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    // 코인 충돌 시 재생할 소리
    [Header("- AudioClip")]
    public AudioClip coinSound;

    // Private
    private AudioSource audioSource;

    // Static 변수: 다른 스크립트나 UI에서 접근 가능
    public static int coinCount = 0;

    void Start()
    {
        // AudioSource 초기화
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        // 충돌한 오브젝트가 Coin 레이어인지 확인
        if (other.gameObject.layer == LayerMask.NameToLayer("Coin"))
        {
            // 코인 개수 증가
            coinCount++;

            // 코인 획득 소리 재생
            if (coinSound != null && audioSource != null)
                audioSource.PlayOneShot(coinSound);

            // 충돌한 코인 오브젝트 제거
            Destroy(other.gameObject);
        }
    }
}