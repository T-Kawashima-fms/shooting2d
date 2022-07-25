using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadButton : MonoBehaviour
{
    private bool isOpened;
    public GameObject parameterPanel;
    public TargetManager targetManager;

    // Objects which parameter can be changed
    public SpriteRenderer bulletSprite;
    public SpriteRenderer ballisticSprite;
    public GameObject[] targetObject;

    void Start()
    {
        isOpened = false;
    }

    void Update()
    {
        
    }

    public void onClicked()
    {
        if(!isOpened)
        {
            bulletSprite.color = new Color32((byte)ParameterManager.ballisticColorRed, (byte)ParameterManager.ballisticColorGreen, (byte)ParameterManager.ballisticColorBlue, 255);
            ballisticSprite.color = new Color32((byte)ParameterManager.ballisticColorRed, (byte)ParameterManager.ballisticColorGreen, (byte)ParameterManager.ballisticColorBlue, 255);
            
            for (int i = 0; i < ParameterManager.targetsParameter.Length; i++)
            {
                if(ParameterManager.targetsParameter[i].image != "")
                {
                    byte[] bytes = System.Convert.FromBase64String(ParameterManager.targetsParameter[i].image); 
                    Texture2D texture = new Texture2D(1, 1);
                    texture.LoadImage(bytes);
                    Sprite newSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
                    SpriteRenderer targetSpriteRenderer = targetObject[i].GetComponent<SpriteRenderer>();
                    targetSpriteRenderer.sprite = newSprite;
                    targetSpriteRenderer.color = new Color32((byte)255, (byte)255, (byte)255, 255);
                    targetObject[i].AddComponent<PolygonCollider2D>();
                }
            }

            targetManager.isPlaying = true;
            parameterPanel.SetActive(false);
        }
        else{ parameterPanel.SetActive(true); }

        isOpened = !isOpened;
    }
}
