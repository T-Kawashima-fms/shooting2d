using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderBallisticColorBlue : ParameterSlider
{

    void Start()
    {
        slider.value = ParameterManager.ballisticColorBlue;
        sliderText.text = (slider.value).ToString();
    }

    public void OnValueChanged()
    {
        ParameterManager.ballisticColorBlue = (int)(slider.value);
        sliderText.text = (ParameterManager.ballisticColorBlue).ToString();
    }
}
