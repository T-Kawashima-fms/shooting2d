using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetD : MonoBehaviour
{
    public float speed;
    private Vector3 direction;

    public Sprite defaultSprite;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer.sprite = defaultSprite;
        spriteRenderer.color = new Color32((byte)255, (byte)255, (byte)0, 255);
        this.Init();
    }

    void Update()
    {
        this.transform.position += direction * speed;
        this.transform.Rotate(new Vector3(0, 0, 360.0f) * Time.deltaTime);
    }

    void OnEnable() { this.Init(); }

    private void Init()
    {
        Vector3 startingPosition = Vector3.zero;
        startingPosition.x = Random.Range(8.5f, -8.5f);
        startingPosition.y = 5.5f;
        startingPosition.z = 1.0f;
        direction = Vector2.down;
        direction.z = 1.0f;
        this.transform.position = startingPosition;
    }

}
