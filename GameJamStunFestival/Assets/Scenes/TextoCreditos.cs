using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextoCreditos : MonoBehaviour
{
    Rigidbody2D rb;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
        speed = 100;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, speed);
        Invoke("bah", 18f);
    }

    public void bah()
    {

        speed = 0;


    }
    public void sair()
    {
        SceneManager.LoadScene("Menu");

    }
}
