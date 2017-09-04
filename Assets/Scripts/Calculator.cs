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

    bool atualizar = false;

    public void OnClickBurgerPlus () {
		burger += 1;
        atualizar = true;
	}
	public void OnClickBurgerMinus(){
        burger--;
        atualizar = true;
    }
	public void OnClickPizzaPlus(){
		pizza++;
        atualizar = true;
    }
	public void OnClickPizzaMinus(){
		pizza--;
        atualizar = true;
    }
	public void OnClickChocPlus(){
		choc++;
        atualizar = true;
    }
	public void OnClickChocMinus(){
		choc--;
        atualizar = true;
    }
	public void OnClickCokePlus(){
		coke++;
        atualizar = true;
    }
	public void OnClickCokeMinus(){
		coke--;
        atualizar = true;
    }
	public void OnClickFriesPlus(){
		fries++;
        atualizar = true;
    }
	public void OnClickFriesMinus(){
		fries--;
        atualizar = true;
    }
	public void OnClickIceCreamPlus(){
		iceCream++;
        atualizar = true;
    }
	public void OnClickIceCreamMinus(){
		iceCream--;
        atualizar = true;
    }
	public void OnClickHotDogPlus(){
		hotDog++;
        atualizar = true;
    }
	public void OnClickHotDogMinus(){
		hotDog--;
        atualizar = true;
    }

    void Update()
    {
        if (atualizar)
        {
            if (burger < 0) { burger = 0; }
            if (pizza < 0) { pizza = 0; }
            if (choc < 0) { choc = 0; }
            if (coke < 0) { coke = 0; }
            if (fries < 0) { fries = 0; }
            if (iceCream < 0) { iceCream = 0; }
            if (hotDog < 0) { hotDog = 0; }
			burgerNum.text = burger.ToString() + " hambúrguer(es)";
			pizzaNum.text = pizza.ToString() + " pizza(s)";
			chocNum.text = choc.ToString() + " chocolate(s)";
			cokeNum.text = coke.ToString() + " refrigerante(s)";
			friesNum.text = fries.ToString() + " batata(s) frita(s)";
			iceNum.text = iceCream.ToString() + " sorvete(s)";
			hotNum.text = hotDog.ToString() + " cachorro(s) quente(s)";
            atualizar = false;
        }
    }

    public void OnClickCalcular() {
        total = burgerKcal * burger + pizzaKcal * pizza + chocolateKcal * choc + cokeKcal * coke + friesKcal * fries + iceCreamKcal * iceCream + hotDogKcal * hotDog;
		MenuMover.goTO = 5;

        result.text = total.ToString();
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

	public void OnClickOK(){
		panel.SetActive (false);
	}
}
