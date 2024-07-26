using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;  

        //you can do this when Screen.width > 2000 pxels. 
        Screen.SetResolution(Screen.width/2, Screen.height/2, true);
    }
}
