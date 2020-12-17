
using UnityEngine;

public class CircleSquareGO : MonoBehaviour
{
    int speed;
    Rigidbody2D rgbd;

    void Start()
    {
        speed = 10;
        rgbd = GetComponent<Rigidbody2D>();
        rgbd.velocity = new Vector2(0, -speed);
    }
}
