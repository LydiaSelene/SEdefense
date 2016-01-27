using UnityEngine;
using System.Collections;

public class Player_Attributes : MonoBehaviour {

	float health;
	float money;
	GameObject lose;

	// Use this for initialization
	void Start () {
		health = 20f;
		GameObject.Find ("GUICanvas/Healthbar/HealthbarImage").SendMessage("initializeMaxHealth", health, SendMessageOptions.RequireReceiver);
		money = 500f;
	}

	//Soll aufgerufen werden, wenn ein Fein den Zielort erreicht.
	public void onHit(){
		health -= 1;
		GameObject.Find ("GUICanvas/Healthbar/HealthbarImage").SendMessage("setHealth", health, SendMessageOptions.RequireReceiver);
		if(health <= 0){
			//TODO
			Debug.Log("You Loose!");
			lose = GameObject.FindGameObjectWithTag ("Lose");
		}
	}

	//Soll aufgerufen werden, wenn ein Fein den Zielort erreicht.
	public void onHit(float amount){
		health -= amount;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
