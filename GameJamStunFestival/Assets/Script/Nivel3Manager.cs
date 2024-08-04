using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel3Manager : MonoBehaviour
{
    public void SelecNiveis()
    {

        SceneManager.LoadScene("SelecaoDeNiveis");



    }
    public void Recomecar()
    {

        SceneManager.LoadScene("Nivel3");



    }
    public void Final()
    {

        SceneManager.LoadScene("Final");



    }
}
