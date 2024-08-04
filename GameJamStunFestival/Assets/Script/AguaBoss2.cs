using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguaBoss2 : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.x > transform.position.x)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);


        }
        if (player.transform.position.x < transform.position.x)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);


        }
        if (player.transform.position.y > transform.position.y)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);


        }
        if (player.transform.position.y < transform.position.y)
        {
            rb.velocity = new Vector2( rb.velocity.x, -speed);


        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("TiroPlayer"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);


        }

    }
}
