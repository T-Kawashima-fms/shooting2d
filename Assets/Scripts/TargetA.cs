using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetA : MonoBehaviour
{
    public float speed;
    private Vector3 direction;
    private string[] types = {"toLeft", "toRight"};

    public Sprite defaultSprite;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer.sprite = defaultSprite;
        spriteRenderer.color = new Color32((byte)0, (byte)0, (byte)255, 255);
        this.Init();
    }

    void Update()
    {
        this.transform.position += direction * speed;
    }

    void OnEnable() { this.Init(); }

    private void Init()
    {
        speed = ParameterManager.targetsParameter[0].speed;
        this.transform.localScale = new Vector3(ParameterManager.targetsParameter[0].size, ParameterManager.targetsParameter[0].size, 1.0f);

        Vector3 startingPosition = Vector3.zero;
        string type = types[Random.Range(0, types.Length)];
        switch (type)
        {
            case "toLeft":
                startingPosition.x = 9.5f;
                direction = Vector2.left;
                break;
            case "toRight":
                startingPosition.x = -9.5f;
                direction = Vector2.right;
                break;
        }
        startingPosition.y = Random.Range(4.5f, -2.5f);
        startingPosition.z = 1.0f;
        direction.z = 1.0f;
        this.transform.position = startingPosition;
    }

}
