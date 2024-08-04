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

    private float volume = 1.0f;

    public void Jogar()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void AbrirOpcoes()
    {
        painelOpcoes.SetActive(true);
    }
    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
    }

    public void SairJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }
}
