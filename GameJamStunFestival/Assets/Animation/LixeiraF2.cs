using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixeiraF2 : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("esteira"))
        {
            rb.velocity = new Vector2(-2.5f, rb.velocity.y);
            


        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lixeira"))
        {
          Destroy(gameObject);
            lixeiras.quantasLixeiras++;


        }


    }
}
