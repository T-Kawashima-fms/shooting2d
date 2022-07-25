using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetParameter 
{
    public float size;
    public float interval;
    public float speed;
    public string image;
    public int score;
}

public static class ParameterManager 
{
    public static int playTime = 15;
    public static int playerHP = 3;

    public static string stageImage = "";

    public static string reticleImage = "";
    public static float reticleSize = 2.0f;

    public static string playerImage = "";
    public static float playerSize = 1.0f;

    public static bool ballisticVisible = true;
    public static int ballisticColorRed = 255;
    public static int ballisticColorGreen = 0;
    public static int ballisticColorBlue = 255;

    public static TargetParameter[] targetsParameter = new TargetParameter[]
    {
        new TargetParameter
        {
            size = 1.0f, 
            interval = 1.0f,
            speed = 0.01f,
            image = "",
            score = 100
        },
        new TargetParameter
        {
            size = 1.0f, 
            interval = 2.0f,
            speed = 0.0075f,
            image = "",
            score = 200
        },
        new TargetParameter
        {
            size = 1.0f, 
            interval = 3.0f,
            speed = 0.005f, 
            image = "",
            score = 300
        },
        new TargetParameter
        {
            size = 1.0f, 
            interval = 4.0f,
            speed = 0.01f,
            image = "",
            score = 400
        }
    };

}
