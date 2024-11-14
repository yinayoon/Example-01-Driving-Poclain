using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    // ���� �浹 �� ����� �Ҹ�
    [Header("- AudioClip")]
    public AudioClip coinSound;

    // Private
    private AudioSource audioSource;

    // Static ����: �ٸ� ��ũ��Ʈ�� UI���� ���� ����
    public static int coinCount = 0;

    void Start()
    {
        // AudioSource �ʱ�ȭ
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        // �浹�� ������Ʈ�� Coin ���̾����� Ȯ��
        if (other.gameObject.layer == LayerMask.NameToLayer("Coin"))
        {
            // ���� ���� ����
            coinCount++;

            // ���� ȹ�� �Ҹ� ���
            if (coinSound != null && audioSource != null)
                audioSource.PlayOneShot(coinSound);

            // �浹�� ���� ������Ʈ ����
            Destroy(other.gameObject);
        }
    }
}