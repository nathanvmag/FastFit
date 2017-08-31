using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMover : MonoBehaviour {
    [SerializeField]
    GameObject[] Scenes;
    int goTO;
	// Use this for initialization
	void Start () {
        goTO = 2;
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, -10), new Vector3(Scenes[goTO].transform.position.x, Scenes[goTO].transform.position.y,-10), 5 * Time.deltaTime);
	}
    public void layoutControler(int where)
    {
        goTO = where;
        Debug.Log("CLique");
    }
}
