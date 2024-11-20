using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // 要跟随的角色
    public Vector3 offset = new Vector3(0, 0, -10); // 摄像机相对于角色的偏移量
    public float smoothSpeed = 5f; // 平滑跟随的速度

    void FixedUpdate()
    {
        // 计算目标位置（角色的位置 + 偏移量）
        Vector3 targetPosition = player.position + offset;

        // 平滑移动摄像机到目标位置
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.fixedDeltaTime);
    }
}
