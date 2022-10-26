using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource A;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (TimerUp.timerActive == true)
        {
            if (!A.isPlaying)
            {
                A.Play();
            }
        }
    }
}
