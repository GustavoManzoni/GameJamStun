using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Command : MonoBehaviour
{
    public Text texto;
    public GameObject W;
    public GameObject S;
    public GameObject A;
    public GameObject D;
    public GameObject Space;
    public void FalarW()
    {
        texto.text = "Andar para frente";
    }

    public void FalarS()
    {
        texto.text = "Andar para trás";
    }

    public void FalarA()
    {
        texto.text = "Andar para esquerda";
    }
    public void FalarD()
    {
        texto.text = "Andar para direita";
    }
    public void FalarSpace()
    {
        texto.text = "Pular";
    }
    public void FalarShift()
    {
        texto.text = "Correr";
    }
}
