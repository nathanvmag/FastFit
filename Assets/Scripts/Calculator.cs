using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

    float burgerKcal = 643, 
          pizzaKcal = 338,
          chocolateKcal = 520,
          cokeKcal = 200,
          friesKcal = 274,
          iceCreamKcal = 200,
          hotDogKcal = 520,
          beerKcal = 146, 
          salgadinhoKcal = 510, 
          acaiKcal = 320, 
          coxinhaKcal = 330,
          total;
    public int burger, pizza, choc, coke, fries, iceCream, hotDog, beer, salgadinho, acai, coxinha;
    public Text burgerNum, pizzaNum, chocNum, cokeNum, friesNum, iceNum, hotNum, beerNum, salgadinhoNum, acaiNum, coxinhaNum, result;
    public Button burgerPlus, burgerMinus,
        pizzaPlus, pizzaMinus,
        chocPlus, chocMinus,
        cokePlus, cokeMinus,
        friesPlus, friesMinus,
        icePlus, iceMinus,
        hotPlus, hotMinus,
        beerPlus, beerMinus,
        salgadinhoPlus, salgadinhoMinus,
        acaiPlus, acaiMinus,
        coxinhaPlus, coxinhaMinus,
        calcular;
    public GameObject deact, act, panel;
    public int[] valores;
    public Text[] txs;
    bool atualizar = false;
    public GameObject[] lines;
    public GameObject aviso;
    public void Start()
    {
        valores = new int[11] { burger, pizza, choc, fries, iceCream, hotDog, beer, salgadinho, acai, coxinha, coke };
        txs = new Text[11] { burgerNum, pizzaNum, chocNum, friesNum, iceNum, hotNum, beerNum, salgadinhoNum, acaiNum, coxinhaNum, cokeNum};
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
    public void OnClickBeerPlus()
    {
        beer++;
        atualizar = true;
    }
    public void OnClickBeerMinus()
    {
        beer--;
        atualizar = true;
    }
    public void OnClickAcaiPlus()
    {
        acai++;
        atualizar = true;
    }
    public void OnClickAcaiMinus()
    {
        acai--;
        atualizar = true;
    }
    public void OnClickSalgadinhosPlus()
    {
        salgadinho++;
        atualizar = true;
    }
    public void OnClickSalgadinhosMinus()
    {
        salgadinho--;
        atualizar = true;
    }
    public void OnClickCoxinhaPlus()
    {
        coxinha++;
        atualizar = true;
    }
    public void OnClickCoxinhaMinus()
    {
        coxinha--;
        atualizar = true;
    }
    
    void Update()
    {
        valores = new int[11] { burger, pizza, choc, fries, iceCream, hotDog, coke, beer, acai, salgadinho, coxinha };
        txs = new Text[11] { burgerNum, pizzaNum, chocNum, friesNum, iceNum, hotNum, cokeNum, beerNum, acaiNum, salgadinhoNum, coxinhaNum };
        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] > 0)
            {
                txs[i].gameObject.SetActive( true);
            }
            else txs[i].gameObject.SetActive(false);
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
            if (beer < 0) { beer = 0; }
            if (salgadinho < 0) { salgadinho = 0; }
            if (acai < 0) { acai = 0; }
            if (coxinha < 0) { coxinha = 0; }

            if (burger > 1) burgerNum.text = burger.ToString() + " hambúrgueres";
            else if (burger == 1)
            {
                burgerNum.text = burger.ToString() + " hambúrguer";
                
            }
            

            if (pizza > 1) pizzaNum.text = pizza.ToString() + " pizzas";
            else if (pizza == 1)
            {
                pizzaNum.text = pizza.ToString() + " pizza";
               
            }
            

            if (choc > 1) chocNum.text = choc.ToString() + " chocolates";
            else if (choc == 1)
            {
                chocNum.text = choc.ToString() + " chocolate";
               
            }
          ;

            if (coke > 1) cokeNum.text = coke.ToString() + " refrigerantes";
            else if (coke == 1)
            {
                cokeNum.text = coke.ToString() + " refrigerante";
               
            }
          

            if (fries > 1) friesNum.text = fries.ToString() + " batatas fritas";
            else if (fries == 1)
            {
                friesNum.text = fries.ToString() + " batata frita";
              
            }
          

            if (iceCream > 1) iceNum.text = iceCream.ToString() + " sorvetes";
            else if (iceCream == 1)
            {
                iceNum.text = iceCream.ToString() + " sorvete";
               
            }
            
                     

            if (hotDog > 1) hotNum.text = hotDog.ToString() + " cachorros quentes";
            else
            {
                hotNum.text = hotDog.ToString() + " cachorro quente";
            }

            if (beer > 1) beerNum.text = beer.ToString() + " cervejas";
            else if (beer == 1)
            {
                beerNum.text = beer.ToString() + " cerveja";
               
            }
           
            
            if (acai > 1) acaiNum.text = acai.ToString() + " açaís";
            else if (acai == 1)
            {
                acaiNum.text = acai.ToString() + " açaí";
               
            }
          

            if (salgadinho > 1) salgadinhoNum.text = salgadinho.ToString() + " salgadinhos";
            else if (salgadinho == 1)
            {
                salgadinhoNum.text = salgadinho.ToString() + " salgadinho";
               
            }
            

            if (coxinha > 1) coxinhaNum.text = coxinha.ToString() + " coxinhas";
            else if (coxinha == 1)
            {
                coxinhaNum.text = coxinha.ToString() + " coxinha";
                
            }
           
        }
        
    }

    public void OnClickCalcular()
    {
        total = burgerKcal * burger + 
                pizzaKcal * pizza + 
                chocolateKcal * choc + 
                cokeKcal * coke + 
                friesKcal * fries + 
                iceCreamKcal * iceCream + 
                hotDogKcal * hotDog +
                beerKcal * beer +
                acaiKcal * acai +
                salgadinhoKcal * salgadinho +
                coxinhaKcal * coxinha;
        if (total != 0)
        {
            MenuMover.goTO = 5;
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
        beer = 0;
        coxinha = 0;
        salgadinho = 0;
        acai = 0;
        atualizar = true;
    }

    public void OnClickOK() {
        panel.SetActive(false);
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
        acai = 0;
        beer = 0;
        salgadinho = 0;
        coxinha = 0;
    }
}
