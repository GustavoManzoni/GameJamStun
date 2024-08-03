using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public GameObject espinho, spawner1;
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
        vida = 250;



    }

    // Update is called once per frame
    void Update()
    {

        if (vida == 0) { 
        
            
        
        
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
  
   




}
