using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerStart = 300;
    public Text timerText;

    void Start()
    {
        timerText.text = timerStart.ToString();
    }

    void Update()
    {
        timerStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timerStart).ToString();
    }
}
