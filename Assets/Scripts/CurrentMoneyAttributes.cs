using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrentMoneyAttributes : MonoBehaviour {

	public int currentMoney;

	// Use this for initialization
	void Start () {
		currentMoney = 1000;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int GetCurrentMoney(){
		return currentMoney;
	}

	public void SetCurrentMoney(int refreshedAmount){
		currentMoney = refreshedAmount;
	}
}