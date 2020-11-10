using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    private float t;

    string minutes;
    string seconds;

    private Boolean ya = false;
    private float startTime;


    private int nextUpdate = 1;
    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    private void FixedUpdate()
    {

        if (Time.time >= nextUpdate)
        {
            nextUpdate=Mathf.FloorToInt(Time.time)+1;
            if ( ((int) t % 60)%10 == 0 && !ya)
            {
                ScoreScript.scoreValue -= 5;
                ya = true;
            }else
            {
                ya = false;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.time - startTime;
        minutes = ((int) t / 60).ToString().PadLeft(2, '0');
        seconds = ((int) t % 60).ToString().PadLeft(2, '0');
        TimerText.text = minutes + ":" + seconds;

        
    }
}
