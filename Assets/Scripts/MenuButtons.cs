using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {
    //Botões da Cena Menu Principal
    public void OnClickEnrijecer()
    {
        SceneManager.LoadScene("enrijecer");
    }
    public void OnClickPerderPeso()
    {
        SceneManager.LoadScene("perderpeso");
    }
    public void OnClickBemEstar()
    {
        SceneManager.LoadScene("bemestar");
    }
}
