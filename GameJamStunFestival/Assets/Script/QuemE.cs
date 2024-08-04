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

            QuemVouSer.virus = false;
            QuemVouSer.Laranja = false;
            QuemVouSer.limao = false;
            QuemVouSer.guarana = false;
            QuemVouSer.uva = false;

        }
        if (QuemVouSer.uva == true)
        {
            Uva.SetActive(true);

            QuemVouSer.virus = false;
            QuemVouSer.Laranja = false;
            QuemVouSer.limao = false;
            QuemVouSer.guarana = false;
            QuemVouSer.uva = false;

        }
        if (QuemVouSer.limao == true)
        {
            Limao.SetActive(true);

            QuemVouSer.virus = false;
            QuemVouSer.Laranja = false;
            QuemVouSer.limao = false;
            QuemVouSer.guarana = false;
            QuemVouSer.uva = false;

        }
        if (QuemVouSer.virus == true)
        {
            Virus.SetActive(true);

            QuemVouSer.virus = false;
            QuemVouSer.Laranja = false;
            QuemVouSer.limao = false;
            QuemVouSer.guarana = false;
            QuemVouSer.uva = false;

        }
        if (QuemVouSer.guarana == true)
        {
            Guarana.SetActive(true);

            QuemVouSer.virus = false;
            QuemVouSer.Laranja = false;
            QuemVouSer.limao = false;
            QuemVouSer.guarana = false;
            QuemVouSer.uva = false;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
