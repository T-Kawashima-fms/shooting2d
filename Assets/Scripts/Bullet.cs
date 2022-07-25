using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;

    public Sight sight;

    private bool isShooting;
    private Vector2 triggeredsightPosition;
    private Vector3 triggeredDirection;

    public SpriteRenderer spriteRenderer;

    public Score score;

    void Start()
    {
        spriteRenderer.color = new Color32((byte)ParameterManager.ballisticColorRed, (byte)ParameterManager.ballisticColorGreen, (byte)ParameterManager.ballisticColorBlue, 255);
        isShooting = false;
    }

    void Update()
    {
        if (isShooting)
        {
            this.transform.position += triggeredDirection * speed * Time.deltaTime;
            if (Mathf.Abs(triggeredsightPosition.x) < Mathf.Abs(transform.position.x))
            {
                isShooting = false;
                this.transform.position = new Vector3(0f, -5f, 0f);
            }
        }
        else
        {
            Vector3 sightPosition = new Vector3(sight.posX, sight.posY, 0f);
            Vector2 lookDir = sightPosition - this.transform.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.Euler(0, 0, angle - 90f);
        }
        
    }

    public void Trigger()
    {
        if (!isShooting)
        {
            Vector3 sightPosition = new Vector3(sight.posX, sight.posY, 0f);
            triggeredsightPosition = sightPosition;
            Vector2 lookDir = sightPosition - this.transform.position;
            float triggeredAngle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
            triggeredDirection = new Vector3(Mathf.Cos(triggeredAngle * Mathf.PI / 180), Mathf.Sin(triggeredAngle * Mathf.PI / 180), 0f);
            isShooting = true;
            // Debug.Log("Trigger! (" + Mathf.Cos(triggeredAngle * Mathf.PI / 180) + ", " + Mathf.Sin(triggeredAngle * Mathf.PI / 180) + ")");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TargetA")
        {          
            score.getScore(ParameterManager.targetsParameter[0].score);
        }
        if (collision.gameObject.tag == "TargetB")
        {          
            score.getScore(ParameterManager.targetsParameter[1].score);
        }
        if (collision.gameObject.tag == "TargetC")
        {          
            score.getScore(ParameterManager.targetsParameter[2].score);
        }
        if (collision.gameObject.tag == "TargetD")
        {          
            score.getScore(ParameterManager.targetsParameter[3].score);
        }
    }
}
