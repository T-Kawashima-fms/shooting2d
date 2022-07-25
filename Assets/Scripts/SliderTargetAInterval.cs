using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderTargetAInterval : ParameterSlider
{
    void Start()
    {
        slider.value = float.Parse((ParameterManager.targetsParameter[0].interval).ToString("f2"));
        sliderText.text = (slider.value).ToString();
    }

    public void OnValueChanged()
    {
        ParameterManager.targetsParameter[0].interval = float.Parse((slider.value).ToString("f2"));
        sliderText.text = (ParameterManager.targetsParameter[0].interval).ToString();
    }
}
