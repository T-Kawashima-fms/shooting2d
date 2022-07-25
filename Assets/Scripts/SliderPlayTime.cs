using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderPlayTime : ParameterSlider
{
    void Start()
    {
        slider.value = ParameterManager.playTime;
        sliderText.text = (slider.value).ToString();
    }

    public void OnValueChanged()
    {
        ParameterManager.playTime = (int)(slider.value);
        sliderText.text = (ParameterManager.playTime).ToString();
    }
}
