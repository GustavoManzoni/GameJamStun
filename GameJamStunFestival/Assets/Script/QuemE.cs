using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuemE : MonoBehaviour
{
    public GameObject Laranja, Uva, Limao, Virus, Guarana;
    // Start is called before the first frame update
    void Start()
    {
        if (QuemVouSer.Laranja == true)
        {
            Laranja.SetActive(true);


        }
        if (QuemVouSer.uva == true)
        {
            Uva.SetActive(true);


        }
        if (QuemVouSer.limao == true)
        {
            Limao.SetActive(true);


        }
        if (QuemVouSer.virus == true)
        {
            Virus.SetActive(true);


        }
        if (QuemVouSer.guarana == true)
        {
            Guarana.SetActive(true);


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
