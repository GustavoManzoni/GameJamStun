
using UnityEngine;

public class Lixeira : MonoBehaviour
{
    public GameObject interactionPrompt, venceu;
    public KeyCode interactionKey = KeyCode.E;
    public float interactionRange = 10.0f;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        interactionPrompt.SetActive(false);
    }

    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance <= interactionRange)
        {
            interactionPrompt.SetActive(true);
            interactionPrompt.transform.position = transform.position + new Vector3(0, 1.5f, 0); // Posiciona o texto acima do objeto

            if (Input.GetKeyDown(interactionKey))
            {
                Interact();
            }
        }
        else
        {
            interactionPrompt.SetActive(false);
        }
    }

    public void Interact()
    {
        lixeiras.lixo1Fase1 = true;
        Destroy(gameObject);
        
            venceu.SetActive(true);


        

    }


}