using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMover : MonoBehaviour {
    [SerializeField]
    GameObject[] Scenes;
    [SerializeField]
    Sprite[] menus;
    [SerializeField]
    Image menuImg;
    public static int goTO;
	// Use this for initialization
	void Start () {
        goTO = 2;
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, -10), new Vector3(Scenes[goTO].transform.position.x, Scenes[goTO].transform.position.y,-10), 10     * Time.deltaTime);
	}
    public void layoutControler(int where)
    {
        goTO = where;
        if (where<=4)
        {
            menuImg.sprite = menus[goTO];
        }
    }
    public void Notify()
    {
        Notification.SendNotification("Ola jamv", "VOCE PEDIU VOCE TEM", 0);
    }

}
