﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public static int score = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Awake() {
        if (PlayerPrefs.HasKey("HighScore")) {
            score = PlayerPrefs.GetInt("HighScore");
        }
        PlayerPrefs.SetInt("HighScore", score);
    }
    void Update()
    {
        Text gt =this.GetComponent<Text>();
        gt.text = "High Score:" + score;
       

        if (score > PlayerPrefs.GetInt("HighScore")) {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
