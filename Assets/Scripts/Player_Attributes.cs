using UnityEngine;
using System.Collections;

public class Player_Attributes : MonoBehaviour {

	float health;
	float money;
	GameObject lose;
	private bool loseBool;

	// Use this for initialization
	void Start () {
		health = 20f;
		GameObject.Find ("GUICanvas/Healthbar/HealthbarImage").SendMessage("initializeMaxHealth", health, SendMessageOptions.RequireReceiver);
		money = 500f;
		GameObject.Find ("GUICanvas/Juwels/CurrentMoneyText").SendMessage("initializeMoney", money, SendMessageOptions.RequireReceiver);
		loseBool = false;
	}

	//Soll aufgerufen werden, wenn ein Fein den Zielort erreicht.
	public void onHit(){
		health -= 1;
		GameObject.Find ("GUICanvas/Healthbar/HealthbarImage").SendMessage("setHealth", health, SendMessageOptions.RequireReceiver);
		if(health <= 0 && !loseBool){
			//TODO
			Debug.Log("You Loose!");
			lose =  Resources.Load ("Prefabs/Lose", typeof(GameObject)) as GameObject;
			Instantiate (lose, Camera.main.ScreenToViewportPoint(new Vector3(0,0,0)), Quaternion.identity);
			loseBool = true;
			Time.timeScale = 0.0f;
		}
	}

	public void giveMoneyFromKilledEnemy(float amount){
		money += amount;
		GameObject.Find ("GUICanvas/Juwels/CurrentMoneyText").SendMessage("setCurrentMoney", money, SendMessageOptions.RequireReceiver);
	}

	public void setMoney(float amount){
		money = amount;
		GameObject.Find ("GUICanvas/Juwels/CurrentMoneyText").SendMessage("setCurrentMoney", money, SendMessageOptions.RequireReceiver);
	}

	//Soll aufgerufen werden, wenn ein Fein den Zielort erreicht.
	public void onHit(float amount){
		health -= amount;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
