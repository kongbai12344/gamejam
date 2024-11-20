using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // 水平移动速度
    public float ascendSpeed = 4f; // 向上飞行速度（降低后飞行幅度更小）
    public float maxVerticalSpeed = 10f; // 垂直方向的最大速度
    public float descendSpeed = 8f; // 快速下降速度

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // 获取 Rigidbody2D 组件
    }

    void Update()
    {
        // 水平移动逻辑
        float horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);

        // 按住 W 键：角色持续向上飞行
        if (Input.GetKeyDown(KeyCode.W))
        {
            AscendOnce(); // 按一下时执行一次向上飞行
        }

        // 按住 S 键：角色快速下降
        if (Input.GetKey(KeyCode.S))
        {
            Descend();
        }
    }

    void AscendOnce()
    {
        // 给角色一个固定的向上速度，确保幅度较低
        rb.velocity = new Vector2(rb.velocity.x, ascendSpeed);
    }

    void Descend()
    {
        // 设置下降速度
        rb.velocity = new Vector2(rb.velocity.x, -descendSpeed);
    }
}
