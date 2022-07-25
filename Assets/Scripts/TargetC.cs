using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetC : MonoBehaviour
{
    public float speed;
    private Vector3 direction;
    private string[] types = {"toLeft", "toRight"};
    private float vertivalSpeed;

    public Sprite defaultSprite;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer.sprite = defaultSprite;
        spriteRenderer.color = new Color32((byte)0, (byte)255, (byte)255, 255);
        this.Init();
    }

    private void Update()
    {
        this.transform.localPosition += direction * speed;

        Vector3 temp = this.transform.position;
        if (temp.y > 4.0f || temp.y < -4.0f) vertivalSpeed = -vertivalSpeed;
        temp.y += vertivalSpeed;
        this.transform.position = temp;
    }

    void OnEnable() { this.Init(); }

    private void Init()
    {
        vertivalSpeed = speed * 3;
        Vector3 startingPosition = Vector3.zero;
        string type = types[Random.Range(0, types.Length)];
        switch (type)
        {
            case "toLeft":
                startingPosition.x = 9.5f;
                startingPosition.y = Random.Range(4.5f, -4.5f);
                direction = Vector2.left;
                break;
            case "toRight":
                startingPosition.x = -9.5f;
                startingPosition.y = Random.Range(4.5f, -4.5f);
                direction = Vector2.right;
                break;
        }
        startingPosition.z = 1.0f;
        direction.z = 1.0f;
        this.transform.position = startingPosition;
    }
}
