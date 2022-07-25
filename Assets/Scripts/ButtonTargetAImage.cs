using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.InteropServices;

public class ButtonTargetAImage : MonoBehaviour
{

#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern string getImage();
#endif

    public TextMeshProUGUI textTargetAImage;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClicked()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Debug.Log(getImage());
        string data = getImage();
        string[] base64 = data.Split(";base64,");
        textTargetAImage.text = base64[0];
        ParameterManager.targetsParameter[0].image = base64[1];
#endif
    }
}