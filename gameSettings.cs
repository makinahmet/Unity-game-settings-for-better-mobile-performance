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

//dont use normal maps on terrains in mobile projects.
//enable Playersettings->Other Settings->Dynamic batching
//disable Playersettings->resolution and presentation->Render outside safe area
