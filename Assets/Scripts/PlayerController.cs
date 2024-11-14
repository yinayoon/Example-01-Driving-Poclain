using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("- Float")]
    public float moveSpeed = 10f; // �̵� �ӵ�
    public float turnSpeed = 50f; // ȸ�� �ӵ�

    [Header("- AudioClip")]
    public AudioClip engineSound; // ���� �Ҹ� Ŭ��

    // Private
    private AudioSource audioSource;

    void Start()
    {
        // AudioSource ������Ʈ �ʱ�ȭ
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null && engineSound != null)
        {
            audioSource.clip = engineSound;
            audioSource.loop = true; // ���� �Ҹ��� �ݺ� ���
            audioSource.volume = 1.0f;
        }
        else
        {
            Debug.LogWarning("AudioSource �Ǵ� Engine Sound�� �������� �ʾҽ��ϴ�.");
        }
    }

    void Update()
    {        
        MovePlayer(); // �̵� ó��
        HandleEngineSound(); // ���� �Ҹ� ó��
    }


    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W)) // ������ �̵�: W
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);        
        if (Input.GetKey(KeyCode.S)) // �ڷ� �̵�: S
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A)) // �������� ȸ��: A
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);        
        if (Input.GetKey(KeyCode.D)) // ���������� ȸ��: D
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }

    void HandleEngineSound()
    {
        // Ű�� ���� ������ ���� �Ҹ��� ���
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (!audioSource.isPlaying) // �̹� ��� ���� �ƴϸ�
                audioSource.Play();
        }
        else
        {            
            if (audioSource.isPlaying) // Ű���� ���� ���� ���� �Ҹ��� ����
                audioSource.Stop();
        }
    }
}