using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUp : MonoBehaviour
{
    public static float timeStart;
    public Text textBox;
    public GameObject menu;
    public Transform Head;
    public float spawnDistance = 1;
    public static bool timerActive = false;
    public static bool won = false;
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
        if (won)
        {
            menu.transform.position = Head.position + new Vector3(Head.forward.x, 0, Head.forward.z).normalized * spawnDistance;
        }
        menu.transform.LookAt(new Vector3(Head.position.x, menu.transform.position.y, Head.position.z));
        menu.transform.forward *= -1;
    }
    public void TimerButton()
    {
        timerActive = true;
    }
}
