using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel2Manager : MonoBehaviour
{
    public void SelecNiveis()
    {

        SceneManager.LoadScene("SelecaoDeNiveis");



    }
    public void Recomecar()
    {

        SceneManager.LoadScene("Nivel2");



    }
    public void Final()
    {

        SceneManager.LoadScene("Nivel3");



    }
}
