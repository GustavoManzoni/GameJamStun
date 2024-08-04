using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel1Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public void recomecar()
    {
        Invoke("CarregarCena", 0.5f);

    }
    public void CarregarCena()
    {

        SceneManager.LoadScene("Nivel1");
    }
    public void Sair()
    {
        SceneManager.LoadScene("SelecaoDeNiveis");


    }
    public void ProximaFase()
    {
        SceneManager.LoadScene("Nivel2");


    }
}
