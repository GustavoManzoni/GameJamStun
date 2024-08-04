using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SelecaoDeNiveis : MonoBehaviour
{

    public UnityEvent boss1, boss2, boss3, sair1, sair2, sair3;
    public GameObject Sel1, Sel2, Sel3;
    public void boss1Funcao()
    {
        boss1.Invoke();
        QuemVouSer.limao = false;
        QuemVouSer.Laranja = false;
        QuemVouSer.guarana = false;
        QuemVouSer.uva = false;
        QuemVouSer.virus = false;


    }
    public void boss2Funcao()
    {
        boss2.Invoke();
        QuemVouSer.limao = false;
        QuemVouSer.Laranja = false;
        QuemVouSer.guarana = false;
        QuemVouSer.uva = false;
        QuemVouSer.virus = false;

    }
    public void boss3Funcao()
    {
        boss3.Invoke();
        QuemVouSer.limao = false;
        QuemVouSer.Laranja = false;
        QuemVouSer.guarana = false;
        QuemVouSer.uva = false;
        QuemVouSer.virus = false;


    }
    public void boss1Sair()
    {
        sair1.Invoke();
        QuemVouSer.clicou1 = false;


    }
    public void boss2Sair()
    {
        sair2.Invoke();
        QuemVouSer.clicou2 = false;


    }
    public void boss3Sair()
    {
        sair3.Invoke();
        QuemVouSer.clicou3 = false;

    }
    public void Jogar1()
    {
        Sel1.SetActive(true);
        QuemVouSer.clicou1 = true;

    }
    public void Jogar2()
    {
        Sel2.SetActive(true);
        QuemVouSer.clicou2 = true;

    }
    public void Jogar3()
    {
        Sel3.SetActive(true);
        QuemVouSer.clicou3 = true;


    }
    public void Sair1()
    {
        Sel1.SetActive(false);

    }
    public void Sair2()
    {
        Sel2.SetActive(false);

    }
    public void Sair3()
    {
        Sel3.SetActive(false);

    }
    public void limao()
    {
        QuemVouSer.limao = true;
        QuemVouSer.Laranja = false;
        QuemVouSer.guarana = false;
        QuemVouSer.uva = false;
        QuemVouSer.virus = false;
        if (QuemVouSer.clicou1 == true)
        {
            SceneManager.LoadScene("Nivel1");
            QuemVouSer.clicou1 = false;
        }
        else if (QuemVouSer.clicou2 == true)
        {
            SceneManager.LoadScene("Nivel 2");
            QuemVouSer.clicou2 = false;
        }
        else if (QuemVouSer.clicou3 == true)
        {
            SceneManager.LoadScene("Nivel 3");
            QuemVouSer.clicou3 = false;
        }
    }
    public void Laranja()
    {
        QuemVouSer.Laranja = true;
        QuemVouSer.limao = false;
        QuemVouSer.guarana = false;
        QuemVouSer.uva = false;
        QuemVouSer.virus = false;
        if (QuemVouSer.clicou1 == true)
        {
            SceneManager.LoadScene("Nivel1");
            QuemVouSer.clicou1 = false;
        }
        else if (QuemVouSer.clicou2 == true)
        {
            SceneManager.LoadScene("Nivel 2");
            QuemVouSer.clicou2 = false;
        }
        else if (QuemVouSer.clicou3 == true)
        {
            SceneManager.LoadScene("Nivel 3");
            QuemVouSer.clicou3 = false;
        }
    }
    public void guarana()
    {

        QuemVouSer.guarana = true;
        QuemVouSer.Laranja = false;
        QuemVouSer.limao = false;
        QuemVouSer.uva = false;
        QuemVouSer.virus = false;
        if (QuemVouSer.clicou1 == true)
        {
            SceneManager.LoadScene("Nivel1");
            QuemVouSer.clicou1 = false;

        }
        else if (QuemVouSer.clicou2 == true)
        {
            SceneManager.LoadScene("Nivel 2");
            QuemVouSer.clicou2 = false;
        }
        else if (QuemVouSer.clicou3 == true)
        {
            SceneManager.LoadScene("Nivel 3");
            QuemVouSer.clicou3 = false;
        }

    }
    public void uva()
    {
        QuemVouSer.uva = true;
        QuemVouSer.Laranja = false;
        QuemVouSer.limao = false;
        QuemVouSer.guarana = false;
        QuemVouSer.virus = false;
        if (QuemVouSer.clicou1 == true)
        {
            SceneManager.LoadScene("Nivel1");
            QuemVouSer.clicou1 = false;

        }
        else if (QuemVouSer.clicou2 == true)
        {
            SceneManager.LoadScene("Nivel 2");
            QuemVouSer.clicou2 = false;
        }
        else if (QuemVouSer.clicou3 == true)
        {
            SceneManager.LoadScene("Nivel 3");
            QuemVouSer.clicou3 = false;
        }
    }
    public void virus()
    {
        QuemVouSer.virus = true;
        QuemVouSer.Laranja = false;
        QuemVouSer.limao = false;
        QuemVouSer.guarana = false;
        QuemVouSer.uva = false;
        if (QuemVouSer.clicou1 == true)
        {
            SceneManager.LoadScene("Nivel1");
            QuemVouSer.clicou1 = false;

        }
        else if (QuemVouSer.clicou2 == true)
        {
            SceneManager.LoadScene("Nivel 2");
            QuemVouSer.clicou2 = false;
        }
        else if (QuemVouSer.clicou3 == true)
        {
            SceneManager.LoadScene("Nivel 3");
            QuemVouSer.clicou3 = false;
        }

    }
}
public static class QuemVouSer
{
    public static bool Laranja, guarana, uva, virus, limao, clicou1, clicou2, clicou3;



}