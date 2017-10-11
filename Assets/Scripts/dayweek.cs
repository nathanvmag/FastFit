using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class dayweek : MonoBehaviour {
    public bool isOpen;
    public bool[] values;
	// Use this for initialization
	void Start () {
        values = new bool[24];
        for (int i = 0; i < values.Length; i++) values[i] = false;
        isOpen = false;
        GameObject father = GameObject.FindGameObjectWithTag("calendarContent");
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((eventData) => { father.GetComponent<ControlCalendar>().clickHorario(gameObject); });


        gameObject.GetComponent<EventTrigger>().triggers.Add(entry);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isOpen)
        {
            int child = 0;
            foreach( Transform t in transform.parent.GetChild(transform.GetSiblingIndex()+1))
            {
              values[child]= t.GetComponent<Toggle>().isOn;
                child++;
            }
        }
	}
}
