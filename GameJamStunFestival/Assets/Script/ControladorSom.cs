using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorSom : MonoBehaviour
{
    private bool estadoSom = true;
    [SerializeField] private AudioSource fundoMusical;
    [SerializeField] private Slider volumeSlider;

    void Start()
    {
       
        fundoMusical.volume = 1.0f;

        
        volumeSlider.value = fundoMusical.volume;

        
        volumeSlider.onValueChanged.AddListener(VolumeMusical);
    }

    public void VolumeMusical(float value)
    {
        fundoMusical.volume = value;
    }
}
