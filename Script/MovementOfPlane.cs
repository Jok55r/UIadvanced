using UnityEngine;

public class MovementOfPlane : MonoBehaviour
{
    public GameObject spawner;
    public Rigidbody2D rb2d;
    public float speed;

    void Update()
    {
        rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
        /*Vector2 move = new Vector2(spawner.transform.position.x * 10f, transform.position.y);
        transform.position = move;*/
    }
}