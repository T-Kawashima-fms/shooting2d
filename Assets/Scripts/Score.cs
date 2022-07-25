using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;

    void Start()
    {
        
    }

    void Update()
    {
    }

    public void getScore(int gotScore)
    {
        score += gotScore;
        scoreText.text = "Score : " + score.ToString();
    }
}
