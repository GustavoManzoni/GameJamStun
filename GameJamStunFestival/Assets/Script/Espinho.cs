using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinho : MonoBehaviour
{
    public float speed = 5.0f;  
    private Vector3 targetPosition;  // Posi��o do player no momento do disparo
    private Vector3 direction;  // Dire��o do movimento

    void Start()
    {
        
        // Define a posi��o do player como alvo
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            targetPosition = player.transform.position;
        }

        // Calcula a dire��o do espinho para o player
        direction = (targetPosition - transform.position).normalized;

        // Rotaciona o espinho para apontar para a dire��o do disparo
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    void Update()
    {
        // Move o espinho na dire��o calculada
        transform.position += direction * speed * Time.deltaTime;
    }

   

}
