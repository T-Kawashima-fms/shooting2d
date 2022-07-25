using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderBallisticColorRed : ParameterSlider
{
    void Start()
    {
        slider.value = ParameterManager.ballisticColorRed;
        sliderText.text = (slider.value).ToString();
    }

    public void OnValueChanged()
    {
        ParameterManager.ballisticColorRed = (int)(slider.value);
        sliderText.text = (ParameterManager.ballisticColorRed).ToString();
    }
}
