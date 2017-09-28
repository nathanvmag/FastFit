using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CalendManager : MonoBehaviour {

    bool dom, seg, ter, qua, qui, sex, sab;

    private void Update()
    {
        GetComponent<Animator>().SetBool("dom", dom);
        GetComponent<Animator>().SetBool("seg", seg);
        GetComponent<Animator>().SetBool("ter", ter);
        GetComponent<Animator>().SetBool("qua", qua);
        GetComponent<Animator>().SetBool("qui", qui);
        GetComponent<Animator>().SetBool("sex", sex);
        GetComponent<Animator>().SetBool("sab", sab);
    }

    public void domClick()
    {
        dom = true;
        seg = false;
        ter = false;
        qua = false;
        qui = false;
        sex = false;
        sab = false;
    }
    public void segClick()
    {
        dom = false;
        seg = true;
        ter = false;
        qua = false;
        qui = false;
        sex = false;
        sab = false;
    }
    public void terClick()
    {
        dom = false;
        seg = false;
        ter = true;
        qua = false;
        qui = false;
        sex = false;
        sab = false;
    }
    public void quaClick()
    {
        dom = false;
        seg = false;
        ter = false;
        qua = true;
        qui = false;
        sex = false;
        sab = false;
    }
    public void quiClick()
    {
        dom = false;
        seg = false;
        ter = false;
        qua = false;
        qui = true;
        sex = false;
        sab = false;
    }
    public void sexClick()
    {
        dom = false;
        seg = false;
        ter = false;
        qua = false;
        qui = false;
        sex = true;
        sab = false;
    }
    public void sabClick()
    {
        dom = false;
        seg = false;
        ter = false;
        qua = false;
        qui = false;
        sex = false;
        sab = true;
    }
}
