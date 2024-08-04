using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel2Manager : MonoBehaviour
{
    public GameObject info;
    public void SelecNiveis()
    {

        SceneManager.LoadScene("SelecaoDeNiveis");



    }
    public void Recomecar()
    {

        SceneManager.LoadScene("Nivel 2");



    }
    public void Final()
    {

        SceneManager.LoadScene("Nivel 3");



    }
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
        SceneManager.LoadScene("SelecaoDeNiveis");
        Time.timeScale = 1.0f;
    }
}
