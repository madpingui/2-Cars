
using UnityEngine;

public class EdgeCollider : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Circle")
        {
            FindObjectOfType<GameController>().GameOver();
        }
        else if (collision.tag == "Cube")
        {
            Destroy(collision.gameObject);
        }
    }
}
