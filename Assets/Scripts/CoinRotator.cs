using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    [Header("- Float")]
    public float rotationSpeed = 50f; // ȸ�� �ӵ�

    void Update()
    {
        // ������ Y���� �������� ȸ��
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}