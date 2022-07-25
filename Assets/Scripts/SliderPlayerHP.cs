using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderPlayerHP : ParameterSlider
{
    void Start()
    {
        slider.value = ParameterManager.playerHP;
        sliderText.text = (slider.value).ToString();
    }

    public void OnValueChanged()
    {
        ParameterManager.playerHP = (int)(slider.value);
        sliderText.text = (ParameterManager.playerHP).ToString();
    }
}
