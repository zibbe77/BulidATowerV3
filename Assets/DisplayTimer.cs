using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayTimer : MonoBehaviour
{
    public Transform Head;
    public GameObject menu;
    public float spawnDistance = 1;
    public Text textBox;
    void Start()
    {

    }


    void Update()
    {
        menu.transform.position = Head.position + new Vector3(Head.forward.x, 0, Head.forward.z).normalized * spawnDistance;
        menu.transform.LookAt(new Vector3(Head.position.x, menu.transform.position.y, Head.position.z));
        menu.transform.forward *= -1;
        textBox.text = TimerUp.timeStart.ToString("F2");
    }
}
