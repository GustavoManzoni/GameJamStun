using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManagerFinal : MonoBehaviour
{
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
        SceneManager.LoadScene("SelecaoDeNiveis");
        Time.timeScale = 1.0f;
    }
}
