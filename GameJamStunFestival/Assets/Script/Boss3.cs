using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3 : MonoBehaviour
{
    public float timer;
    public int vida;
    public GameObject aviso1, aviso2, aviso3, aviso4, spawner1, spawner2,spawner3, spawner4, spawner5, broca, broca2, aviso5, lixeira;
    void Start()
    {
        vida = 280;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            int RandomNumero = Random.Range(1, 3);
            if(RandomNumero == 1)
            {
                Ataque1();


            }
            if (RandomNumero == 2)
            {
                Ataque2();


            }
            timer = 0;


        }
        if(vida <= 0)
        {

            Instantiate(lixeira, transform.position, transform.rotation);
            Destroy(gameObject);    

        }


    }
    public void Ataque1()
    {
        aviso1.SetActive(true);
        aviso2.SetActive(true);
        aviso5.SetActive(true);
        Invoke("DesatAviso", 0.7f);
        Invoke("Ataque1Pause", 0.7f);

    }
    public void Ataque1Pause() 
    {
        Instantiate(broca, spawner1.transform.position, spawner1.transform.rotation);
        Instantiate(broca, spawner2.transform.position, spawner2.transform.rotation);
        Instantiate(broca, spawner5.transform.position, spawner5.transform.rotation);
    }
    public void DesatAviso()
    {
        aviso1.SetActive(false);
        aviso2.SetActive(false);
        aviso5.SetActive(false);
    }
    public void Ataque2()
    {
        aviso3.SetActive(true);
        aviso4.SetActive(true);
        Invoke("DesatAviso2", 0.7f);
        Invoke("Ataque2Pause", 0.7f);

    }
    public void Ataque2Pause()
    {
        Instantiate(broca2, spawner3.transform.position, spawner3.transform.rotation);
        Instantiate(broca2, spawner4.transform.position, spawner4.transform.rotation);
    }
    public void DesatAviso2()
    {
        aviso3.SetActive(false);
        aviso4.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TiroPlayer")){

            vida -= 10;


        }
    }
}
