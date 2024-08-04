using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public GameObject Cadeado1, Cadeado2;

    private void Update()
    {
        if (lixeiras.lixo1Fase1)
        {

            Cadeado1.SetActive(false);   

        }
        if (lixeiras.lixo2Fase2)
        {

            Cadeado2.SetActive(false);

        }



    }
    public GameObject info;

    public void InfoAbrir()
    {
        info.SetActive(true);
    }
    public void InfoFechar()
    {
        info.SetActive(false);
    }
    public void SairFase()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }
}
