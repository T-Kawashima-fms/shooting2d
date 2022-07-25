using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBallistic : MonoBehaviour
{
    public Toggle toggle;
    public GameObject ballistic;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnToggled()
    {
        ParameterManager.ballisticVisible = toggle.isOn;
        if(ParameterManager.ballisticVisible) { ballistic.SetActive(true); }
        else { ballistic.SetActive(false); }
    }
}
