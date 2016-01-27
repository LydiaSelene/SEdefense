using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrentMoneyAttributes : MonoBehaviour {

	public float currentMoney;
	Text currentMoneyString;

	// Use this for initialization
	void Start () {
		//currentMoney = 1000;
		//currentMoneyString = GetComponent<Text> ();
		//currentMoneyString.text = " " + currentMoney; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void initializeMoney(float money){
		currentMoney = money;
		currentMoneyString = GetComponent<Text> ();
		currentMoneyString.text = " " + currentMoney; 
	}

	public int GetCurrentMoney(){
		return (int) currentMoney;
	}

	public void setCurrentMoney(float refreshedAmount){
		currentMoney = refreshedAmount;
		currentMoneyString.text = " " + currentMoney; 
	}
}