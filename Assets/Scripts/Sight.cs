using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{

    public Bullet bullet;

    public float posX { get; set; }
    public float posY { get; set; }
    
    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        var cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posX = cursorPos.x;
        posY = cursorPos.y;
        transform.position = new Vector3(Mathf.Clamp(posX, -9, 9), Mathf.Clamp(posY, -5, 5), 1f);

        // マウスクリックで弾発射
        if (bullet != null)
        {
            if (Input.GetMouseButtonDown(0)) { bullet.Trigger(); }
        }
    }
}
