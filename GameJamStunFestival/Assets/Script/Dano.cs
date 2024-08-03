using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dano : MonoBehaviour
{
    

    private void Start()
    {
        Invoke("desativar", 0.5f);
    }

    public void  desativar()
    {
        this.gameObject.SetActive(false);

    }
  

}
