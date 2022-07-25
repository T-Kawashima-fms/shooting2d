using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetB : MonoBehaviour
{
    public float speed;
    private Vector3 direction;
    private string[] types = {"toLeft", "toRight"};

    public Sprite defaultSprite;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer.sprite = defaultSprite;
        spriteRenderer.color = new Color32((byte)255, (byte)0, (byte)0, 255);
        this.Init();
    }

    void Update()
    {
        this.transform.position += direction * speed;

        Vector3 temp = this.transform.position;
        temp.y = Mathf.Sin(this.transform.position.x);
        this.transform.position = temp;
    }

    void OnEnable() { this.Init(); }

    private void Init()
    {
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
