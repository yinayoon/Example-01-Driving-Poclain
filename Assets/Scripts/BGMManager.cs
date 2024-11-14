using UnityEngine;

public class BGMManager : MonoBehaviour
{
    // BGM���� ����� AudioClip
    [Header ("- AudioClip")]
    public AudioClip bgmClip;

    // Private
    private AudioSource audioSource;

    void Start()
    {
        // AudioSource ������Ʈ �ʱ�ȭ
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null && bgmClip != null)
        {
            // AudioSource ����
            audioSource.clip = bgmClip; // ����� Ŭ�� ����
            audioSource.loop = true; // �ݺ� ��� Ȱ��ȭ
            audioSource.playOnAwake = true; // ���� �� �ڵ� ���
            audioSource.volume = 0.5f; // ���� ���� (0.0 ~ 1.0)

            // BGM ���
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource �Ǵ� BGM Clip�� �������� �ʾҽ��ϴ�.");
        }
    }
}