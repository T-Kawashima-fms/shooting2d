using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider;
    private float timer;

    public GameObject resultPanel;

    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = ParameterManager.playTime;
        slider.value = ParameterManager.playTime;
    }

    void Update()
    {
        timer += Time.deltaTime;
        slider.value = ParameterManager.playTime - timer;
        if (slider.value <= 0)
        {
            Finish();
        }
    }

    private void Finish()
    {
        resultPanel.SetActive(true);
    }
}
