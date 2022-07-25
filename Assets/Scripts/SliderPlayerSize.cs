using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderPlayerSize : ParameterSlider
{
    void Start()
    {
        slider.value = ParameterManager.playerSize;
        sliderText.text = (slider.value).ToString("f2");
    }

    public void OnValueChanged()
    {
        ParameterManager.playerSize = (slider.value);
        sliderText.text = (ParameterManager.playerSize).ToString("f2");
    }
}
