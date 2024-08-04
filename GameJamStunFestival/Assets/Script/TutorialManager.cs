using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
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
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }
}
