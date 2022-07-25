using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderTargetAScore : ParameterSlider
{
    void Start()
    {
        slider.value = (int)(ParameterManager.targetsParameter[0].score);
        sliderText.text = (slider.value).ToString();
    }

    public void OnValueChanged()
    {
        ParameterManager.targetsParameter[0].score = (int)(slider.value);
        sliderText.text = (ParameterManager.targetsParameter[0].score).ToString();
    }
}
