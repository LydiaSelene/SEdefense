using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class initiateBowTower : MonoBehaviour {

	public GameObject prefab;
	public GameObject currentMoneyText;
	GameObject obj;
	public bool hold;
	private float mousePosX;
	private float mousePosY;
	Text currentMoneyString;
	private int currentMoney;
	public int cost;
	CurrentMoneyAttributes moneyScript;

	// Use this for initialization
	void Start () {
		moneyScript = currentMoneyText.GetComponent<CurrentMoneyAttributes> ();
		currentMoney = moneyScript.GetCurrentMoney();
		hold = false;
		currentMoneyString = currentMoneyText.GetComponent<Text> ();
		currentMoneyString.text = " " + currentMoney; 
	}

	// Update is called once per frame
	void Update () {
		if (hold) {
			obj.transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 1));
		}
		if (Input.GetMouseButtonDown (0)) {
			currentMoney = moneyScript.GetCurrentMoney();
			if (hold && currentMoney >= cost) {
				currentMoney -= cost; 
				currentMoneyString.text = " " + currentMoney; 
				hold = false;
				moneyScript.SetCurrentMoney(currentMoney);
			} else if(currentMoney < cost){
				Debug.Log ("Not enough money!");
			}
		} else if (Input.GetMouseButtonDown (1)) {
			if (hold) {
				Destroy (obj);
				hold = false;
			}
		}
	}

	public void InstantiateBowTower(){
		hold = true;
		mousePosX = Input.mousePosition.x;
		mousePosY = Input.mousePosition.y;
		var objectPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePosX, mousePosY, 1));
		obj = Instantiate (prefab, objectPos, Quaternion.identity) as GameObject;
	}
		
}
