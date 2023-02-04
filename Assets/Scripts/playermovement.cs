using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public GameObject Player;

    private float MovementDirection;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        MovementDirection = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MovementDirection * Time.deltaTime * speed, rb.velocity.y);
        
        if (Player.transform.position.x > 8.9)
        {
            Player.transform.position = new Vector3(- 8.9f, Player.transform.position.y, 0);
        }
        if (Player.transform.position.x < -8.9)
        {
            Player.transform.position = new Vector3(8.9f, Player.transform.position.y, 0);

        }
    }
}
