using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    //Botões do Menu
	public void OnClickMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void OnClickCalculadora()
    {
        SceneManager.LoadScene("calculadora");
    }
    public void OnClickPDC() {
        SceneManager.LoadScene("pdc");
    }
    public void OnClickCalendario() {
        SceneManager.LoadScene("calendario");
    }
    public void OnClickConfiguracoes()
    {
        SceneManager.LoadScene("configuracoes");
    }
}
