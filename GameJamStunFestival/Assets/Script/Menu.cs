using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nomeDoLeveldeJogo;
    public GameObject painelMenuInicial;
    public GameObject painelOpcoes;
    public GameObject sair;
    public GameObject play;
    public GameObject abrirMenu;

    private float volume = 1.0f; // Volume inicial

    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void AbrirOpcoes()
    {
        SceneManager.LoadScene("Info");
    }

    public void AbrirJogo()
    {
        play.SetActive(true);
    }

    public void FecharOpcoes()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SairJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }

    public void AbrirMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Sair()
    {
        {
            Application.Quit();
        }
    }
}
