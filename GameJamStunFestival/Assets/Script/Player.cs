using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float horizontal;
    public int speed, forcaDePulo;
    Rigidbody2D rb;
    public Transform foot;
    public bool groundCheck;
    public int Vida;
    public GameObject Cor1, Cor2, Cor3;
    public bool olhandoDireita;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Vida = 3;
        olhandoDireita = true;
    }

    // Update is called once per frame
    void Update()
    {






        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            animator.SetBool("Correndo", true);


        }
        else
        {

            animator.SetBool("Correndo", false);

        }

        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        groundCheck = Physics2D.OverlapCircle(foot.position, 0.05f);
        Flip();
        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            rb.AddForce(new Vector2(rb.velocity.x, forcaDePulo * 100));
            animator.SetBool("Pulando", true);

        }
        if (rb.velocity.y != 0)
        {
            animator.SetBool("Pulando", true);


        }
        if (groundCheck && rb.velocity.y == 0)
        {
            animator.SetBool("Pulando", false);


        }
        if (Vida <= 0)
        {

            Destroy(gameObject);
            Cor1.SetActive(false);
        }
        if (Vida == 2)
        {
            Cor3.SetActive(false);


        }
        if (Vida == 1)
        {
            Cor3.SetActive(false);
            Cor2.SetActive(false);


        }

    }
    void Flip()
    {
        if (horizontal > 0 && !olhandoDireita || horizontal < 0 && olhandoDireita)
        {
            olhandoDireita = !olhandoDireita;
            Vector2 localscale = transform.localScale;
            localscale.x *= -1;
            transform.localScale = localscale;
        }
    }
    public void tomarDano()
    {
        Vida -= 1;
    }

    //Animação, yes baby


}
