using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    [Header("- Float")]
    public float rotationSpeed = 50f; // 회전 속도

    void Update()
    {
        // 코인을 Y축을 기준으로 회전
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}