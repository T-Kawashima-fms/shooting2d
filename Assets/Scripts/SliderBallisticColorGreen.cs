using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderBallisticColorGreen : ParameterSlider
{
    void Start()
    {
        slider.value = ParameterManager.ballisticColorGreen;
        sliderText.text = (slider.value).ToString();
    }

    public void OnValueChanged()
    {
        ParameterManager.ballisticColorGreen = (int)(slider.value);
        sliderText.text = (ParameterManager.ballisticColorGreen).ToString();
    }
}
