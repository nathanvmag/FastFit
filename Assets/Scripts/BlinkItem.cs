using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkItem : MonoBehaviour {

    public GameObject itemToBlink;
    
    IEnumerator wait()
    {
        itemToBlink.SetActive(true);
        yield return new WaitForSeconds(1);
        itemToBlink.SetActive(false);
    }

    public void onClickFood()
    {
        Debug.Log("clic");
        StartCoroutine(wait());
    }
}
