using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smooth = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 newPos = new Vector3(
            target.position.x,
            target.position.y,
            transform.position.z // 카메라 z 그대로 유지
        );

        transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
    }
}
