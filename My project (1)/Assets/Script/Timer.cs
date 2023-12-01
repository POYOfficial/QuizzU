using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public Slider slider;

    [Header("Timer Settings")]
    public float currentTime;
    public float timeMax;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    void Start()
    {
        timeMax = currentTime;
    }


    void Update()
    {
        slider.value = currentTime / timeMax;

        

        if(currentTime >= 0)
        {
            currentTime -= Time.deltaTime;

        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            currentTime = timeMax;
        }
    }
    
}
