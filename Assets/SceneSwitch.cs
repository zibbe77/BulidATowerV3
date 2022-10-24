using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitch : MonoBehaviour
{
    public TMPro.TMP_Dropdown myDrop;
    public void SetScene()
    {
        if (myDrop.value == 0)
        {
            SceneManager.LoadScene(0);
        }
        if (myDrop.value == 1)
        {
            SceneManager.LoadScene(1);
        }
        if (myDrop.value == 2)
        {
            print("yes2");
        }
        if (myDrop.value == 3)
        {
            print("yes3");
        }

    }
}
