using UnityEngine;

public class BGMManager : MonoBehaviour
{
    // BGM으로 재생할 AudioClip
    [Header ("- AudioClip")]
    public AudioClip bgmClip;

    // Private
    private AudioSource audioSource;

    void Start()
    {
        // AudioSource 컴포넌트 초기화
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null && bgmClip != null)
        {
            // AudioSource 설정
            audioSource.clip = bgmClip; // 재생할 클립 설정
            audioSource.loop = true; // 반복 재생 활성화
            audioSource.playOnAwake = true; // 시작 시 자동 재생
            audioSource.volume = 0.5f; // 볼륨 설정 (0.0 ~ 1.0)

            // BGM 재생
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource 또는 BGM Clip이 설정되지 않았습니다.");
        }
    }
}