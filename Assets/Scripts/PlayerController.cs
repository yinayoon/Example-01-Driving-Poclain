using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("- Float")]
    public float moveSpeed = 10f; // 이동 속도
    public float turnSpeed = 50f; // 회전 속도

    [Header("- AudioClip")]
    public AudioClip engineSound; // 엔진 소리 클립

    // Private
    private AudioSource audioSource;

    void Start()
    {
        // AudioSource 컴포넌트 초기화
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null && engineSound != null)
        {
            audioSource.clip = engineSound;
            audioSource.loop = true; // 엔진 소리는 반복 재생
            audioSource.volume = 1.0f;
        }
        else
        {
            Debug.LogWarning("AudioSource 또는 Engine Sound가 설정되지 않았습니다.");
        }
    }

    void Update()
    {        
        MovePlayer(); // 이동 처리
        HandleEngineSound(); // 엔진 소리 처리
    }


    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W)) // 앞으로 이동: W
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);        
        if (Input.GetKey(KeyCode.S)) // 뒤로 이동: S
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A)) // 왼쪽으로 회전: A
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);        
        if (Input.GetKey(KeyCode.D)) // 오른쪽으로 회전: D
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }

    void HandleEngineSound()
    {
        // 키가 눌려 있으면 엔진 소리를 재생
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (!audioSource.isPlaying) // 이미 재생 중이 아니면
                audioSource.Play();
        }
        else
        {            
            if (audioSource.isPlaying) // 키에서 손을 떼면 엔진 소리를 멈춤
                audioSource.Stop();
        }
    }
}