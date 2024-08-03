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

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.7f;
     
        player = GameObject.FindWithTag("Player");
        
        



    }

    // Update is called once per frame
    void Update()
    {
       



        time += Time.deltaTime;
        if (time > 2)
        {
            Atirar();
            time = 0;

        }

       
        


    }
   
    public void Atirar()
    {

        Instantiate(espinho, spawner1.transform.position, spawner1.transform.rotation);
       



    }
  
   




}
