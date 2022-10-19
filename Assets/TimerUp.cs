using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUp : MonoBehaviour
{
    public float timeStart;
    public Text textBox;

    public static bool timerActive = false;
    void Start()
    {
        textBox.text = timeStart.ToString("F2");
    }
    void Update()
    {
        if (timerActive)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
        }
    }
    public void TimerButton()
    {
        timerActive = true;
    }
}
