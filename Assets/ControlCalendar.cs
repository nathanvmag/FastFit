using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlCalendar : MonoBehaviour {
    [SerializeField]
    GameObject horarioprefab;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
	}
    public void clickHorario(GameObject gb)
    {
        GameObject father = GameObject.FindGameObjectWithTag("calendarContent");
        if (!gb.GetComponent<dayweek>().isOpen)
        {
            GameObject horario = Instantiate(horarioprefab, father.transform.position, Quaternion.identity, father.transform) as GameObject;
            father.GetComponent<RectTransform>().sizeDelta += new Vector2(0, 276);
            horario.transform.SetSiblingIndex(gb.transform.GetSiblingIndex() + 1);
            int child = 0;
           foreach(Transform t in horario.transform)
            {
               t.GetComponent<Toggle>().isOn = gb.GetComponent<dayweek>().values[child];
                child++;
            }

        }
        else
        {
            Destroy(father.transform.GetChild(gb.transform.GetSiblingIndex() + 1).gameObject);
            father.GetComponent<RectTransform>().sizeDelta += new Vector2(0,- 276);
        }
        gb.GetComponent<dayweek>().isOpen = !gb.GetComponent<dayweek>().isOpen;
    }
}
