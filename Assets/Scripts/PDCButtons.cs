using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PDCButtons : MonoBehaviour {
    //Botões da Cena Partes do Corpo
    public void OnClickGluteos()
    {
       
    }
    public void OnClickCoxas()
    {
        SceneManager.LoadScene("coxas");
    }
    public void OnClickCostas()
    {
        SceneManager.LoadScene("costas");
    }
    public void OnClickPerna()
    {
        SceneManager.LoadScene("perna");
    }
    public void OnClickAbdomen()
    {
        SceneManager.LoadScene("abdomen");
    }
    public void OnClickBraco()
    {
        SceneManager.LoadScene("braco");
    }
}
