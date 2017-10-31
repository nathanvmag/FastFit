using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Notification : MonoBehaviour { 
   static AndroidJavaClass jc,Plugin;
   static  AndroidJavaObject jo;   
   
    
	// Use this for initialization
	void Start () {      

	}
   
    public static void SendNotification(String Title, String ContentText,int id)
    {
       
        try
        {
            AndroidJNI.AttachCurrentThread();
            jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
            Plugin = new AndroidJavaClass("com.example.lib.Logic");
            string s = Plugin.CallStatic<string>("teste", "veryBueno");
            Debug.Log(s);
            Plugin.CallStatic("ola", jo,Title,ContentText,id);
        }
        catch(Exception e)
        {
            Debug.Log(e.ToString());
        }

    }
	
	
}
