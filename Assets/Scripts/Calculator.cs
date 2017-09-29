using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

    float burgerKcal = 643;
    float pizzaKcal = 338;
    float chocolateKcal = 520;
    float cokeKcal = 200;
    float friesKcal = 274;
    float iceCreamKcal = 200;
    float hotDogKcal = 520;
    float total;
    public int burger, pizza, choc, coke, fries, iceCream, hotDog;
    public Text burgerNum, pizzaNum, chocNum, cokeNum, friesNum, iceNum, hotNum, result;
    public Button burgerPlus, burgerMinus, pizzaPlus, pizzaMinus, chocPlus, chocMinus, cokePlus, cokeMinus,
        friesPlus, friesMinus, icePlus, iceMinus, hotPlus, hotMinus, calcular;
    public GameObject deact, act, panel;
    public int[] valores;
    public Text[] txs;
    bool atualizar = false;
    public GameObject[] lines;
    public GameObject aviso;
    public void Start()
    {
        valores = new int[7] { burger, pizza, choc, fries, iceCream, hotDog, coke };
        txs = new Text[7] { burgerNum, pizzaNum, chocNum, friesNum, iceNum, hotNum, cokeNum };
    }
    public void OnClickBurgerPlus() {
        burger += 1;
        atualizar = true;
    }
    public void OnClickBurgerMinus() {
        burger--;
        atualizar = true;
    }
    public void OnClickPizzaPlus() {
        pizza++;
        atualizar = true;
    }
    public void OnClickPizzaMinus() {
        pizza--;
        atualizar = true;
    }
    public void OnClickChocPlus() {
        choc++;
        atualizar = true;
    }
    public void OnClickChocMinus() {
        choc--;
        atualizar = true;
    }
    public void OnClickCokePlus() {
        coke++;
        atualizar = true;
    }
    public void OnClickCokeMinus() {
        coke--;
        atualizar = true;
    }
    public void OnClickFriesPlus() {
        fries++;
        atualizar = true;
    }
    public void OnClickFriesMinus() {
        fries--;
        atualizar = true;
    }
    public void OnClickIceCreamPlus() {
        iceCream++;
        atualizar = true;
    }
    public void OnClickIceCreamMinus() {
        iceCream--;
        atualizar = true;
    }
    public void OnClickHotDogPlus() {
        hotDog++;
        atualizar = true;
    }
    public void OnClickHotDogMinus() {
        hotDog--;
        atualizar = true;
    }
    
    void Update()
    {
        valores = new int[7] { burger, pizza, choc, fries, iceCream, hotDog, coke };
        txs = new Text[7] { burgerNum, pizzaNum, chocNum, friesNum, iceNum, hotNum, cokeNum };
        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] > 0)
            {
                txs[i].enabled = true;
            }
            else txs[i].enabled = false;
        }
        if (atualizar)
        {
            if (burger < 0) { burger = 0; }
            if (pizza < 0) { pizza = 0; }
            if (choc < 0) { choc = 0; }
            if (coke < 0) { coke = 0; }
            if (fries < 0) { fries = 0; }
            if (iceCream < 0) { iceCream = 0; }
            if (hotDog < 0) { hotDog = 0; }

            if (burger > 1) burgerNum.text = burger.ToString() + " hambúrgueres";
            else if (burger == 1)
            {
                burgerNum.text = burger.ToString() + " hambúrguer";
                lines[0].SetActive(true);
            }
            else lines[0].SetActive(false);

            if (pizza > 1) pizzaNum.text = pizza.ToString() + " pizzas";
            else if (pizza == 1)
            {
                pizzaNum.text = pizza.ToString() + " pizza";
                lines[1].SetActive(true);
            }
            else lines[1].SetActive(false);

            if (choc > 1) chocNum.text = choc.ToString() + " chocolates";
            else if (choc == 1)
            {
                chocNum.text = choc.ToString() + " chocolate";
                lines[2].SetActive(true);
            }
            else lines[2].SetActive(false);

            if (coke > 1) cokeNum.text = coke.ToString() + " refrigerantes";
            else if (coke == 1)
            {
                cokeNum.text = coke.ToString() + " refrigerante";
                lines[3].SetActive(true);
            }
            else lines[3].SetActive(false);

            if (fries > 1) friesNum.text = fries.ToString() + " batatas fritas";
            else if (fries == 1)
            {
                friesNum.text = fries.ToString() + " batata frita";
                lines[4].SetActive(true);
            }
            else lines[4].SetActive(false);

            if (iceCream > 1) iceNum.text = iceCream.ToString() + " sorvetes";
            else if (iceCream == 1)
            {
                iceNum.text = iceCream.ToString() + " sorvete";
                lines[5].SetActive(true);
            }
            else lines[5].SetActive(false);

            if (hotDog > 1) hotNum.text = hotDog.ToString() + " cachorros quentes";
            else
            {
                hotNum.text = hotDog.ToString() + " cachorro quente";

            }
        }
        
    }

    public void OnClickCalcular()
    {
        total = burgerKcal * burger + pizzaKcal * pizza + chocolateKcal * choc + cokeKcal * coke + friesKcal * fries + iceCreamKcal * iceCream + hotDogKcal * hotDog;
        if (total != 0)
        {
            MenuMover.goTO = 5;

            StartCoroutine(closeAviso());
            aviso.SetActive(true);
            result.text = total.ToString() + " kcal";
        }
        else Debug.Log("Sem");
    }

    public void OnClickVoltarCalc() {
        MenuMover.goTO = 1;
        total = 0;
        burger = 0;
        pizza = 0;
        choc = 0;
        coke = 0;
        fries = 0;
        iceCream = 0;
        hotDog = 0;
        atualizar = true;
       


    }

    public void OnClickOK() {
        panel.SetActive(false);
    }
    IEnumerator closeAviso()
    {
        yield return new WaitForSeconds(5);
        aviso.SetActive(false);
        Debug.Log("fechou");
    }
    public void closeAviso1()
    {
        aviso.SetActive(false);
    }

    public void OnClickClear()
    {
        burger = 0;
        pizza = 0;
        choc = 0;
        coke = 0;
        fries = 0;
        iceCream = 0;
        hotDog = 0;
        
    }
}
