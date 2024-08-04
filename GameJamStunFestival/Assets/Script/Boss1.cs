using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public GameObject espinho, spawner1, venceu, lixeira, CL, CJ;
    public float time, speed;
    GameObject player;
    Animator anim;
    public int vida;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.7f;
     
        player = GameObject.FindWithTag("Player");
        anim = GetComponent<Animator>();
       


    }

    // Update is called once per frame
    void Update()
    {

        if (vida <= 0) {
            CL.SetActive(true);
            CJ.SetActive(false);
            Instantiate(lixeira, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
           
        
        }
       
        
        time += Time.deltaTime;
        if (time > 2)
        {
            Atirar();
            time = 0;
            anim.SetBool("Atirar", true);
            Invoke("atir", 0.4f);
        }

       
        


    }
   
    public void Atirar()
    {

        Instantiate(espinho, spawner1.transform.position, spawner1.transform.rotation);
       



    }
    public void atir()
    {

        anim.SetBool("Atirar", false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TiroPlayer"))
        {

            vida -= 10;
            Destroy(collision.gameObject);



        }


    }




}
