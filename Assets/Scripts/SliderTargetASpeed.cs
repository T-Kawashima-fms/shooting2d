using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderTargetASpeed : ParameterSlider
{
    void Start()
    {
        slider.value = float.Parse((ParameterManager.targetsParameter[0].speed).ToString("f3"));
        sliderText.text = (slider.value).ToString();
    }

    public void OnValueChanged()
    {
        ParameterManager.targetsParameter[0].speed = float.Parse((slider.value).ToString("f3"));
        sliderText.text = (ParameterManager.targetsParameter[0].speed).ToString();
    }
}
