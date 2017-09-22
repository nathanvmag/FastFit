using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour {
    void Awake()
    {
        if (Application.platform == RuntimePlatform.Android) getResized();
    }
    void getResized()
    {
        int width = 473;
        int height = 700;
        int mywidth = Screen.currentResolution.width;
        int myheight = Screen.currentResolution.height;
        float multiplyer = 0;
        while(width*multiplyer<mywidth&&height*multiplyer<myheight)
        {
            multiplyer += 0.1f;
        }
       
       
        Screen.SetResolution((int) (width*multiplyer), (int)(height*multiplyer),true);
    }
}
