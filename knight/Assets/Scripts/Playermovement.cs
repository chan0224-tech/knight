using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    Rigidbody2D rb;
    Vector2 inputDir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 키보드 입력 받기 (WASD / 방향키)
        float x = Input.GetAxisRaw("Horizontal"); // A/D 또는 ←/→
        float y = Input.GetAxisRaw("Vertical");   // W/S 또는 ↑/↓
        inputDir = new Vector2(x, y).normalized;
    }

    void FixedUpdate()
    {
        // 실제 이동 처리
        rb.linearVelocity = inputDir * moveSpeed;
    }
}
