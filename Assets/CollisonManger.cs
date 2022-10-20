using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonManger : MonoBehaviour
{
    // Start is called before the first frame update
    bool goal = false;
    bool cube = false;
    public GameObject menu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (goal == true && cube == true)
        {
            TimerUp.timerActive = false;
            menu.SetActive(true);
            
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Goal")
        {
            goal = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Block")
        {
            goal = false;
        }
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.transform.tag == "Block")
        {
            cube = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.transform.tag == "Block")
        {
            cube = false;
        }
    }
}