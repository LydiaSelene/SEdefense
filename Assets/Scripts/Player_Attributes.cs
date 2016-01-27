using UnityEngine;
using System.Collections;

public class Player_Attributes : MonoBehaviour {

	int lives;
	int money;

	// Use this for initialization
	void Start () {
		lives = 20;
		money = 500;
	}

	//Soll aufgerufen werden, wenn ein Fein den Zielort erreicht.
	public void onHit(){
		lives -= 1;
	}

	//Soll aufgerufen werden, wenn ein Fein den Zielort erreicht.
	public void onHit(int amount){
		lives -= amount;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
