using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistic : MonoBehaviour
{
    public Bullet bullet;
    public GameObject ballistic;

    public SpriteRenderer spriteRenderer;

    public Score score;

    void Start()
    {
        spriteRenderer.color = new Color32((byte)ParameterManager.ballisticColorRed, (byte)ParameterManager.ballisticColorGreen, (byte)ParameterManager.ballisticColorBlue, 255);
        if(ParameterManager.ballisticVisible) { ballistic.SetActive(true); }
        else { ballistic.SetActive(false); }
    }

    void Update()
    {
        // Rotate
        this.transform.rotation = bullet.transform.rotation;
        Vector3 bulletPos = bullet.transform.position;
        float distance = Vector3.Distance(bulletPos, this.transform.position);

        // LocalScale
        Vector3 tempLocalScale = this.transform.localScale;
        tempLocalScale.y = distance;
        this.transform.localScale = tempLocalScale;
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
