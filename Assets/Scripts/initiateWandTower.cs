using UnityEngine;
using System.Collections;
using UnityEngine.UI;	
	/*
	Dieses Script verwaltet den Zauber-Turm, der Gegner mit einer hohen Reichweite beschießt
	Außerdem greift dieses script auf die geldanzeige zu und zieht die kosten für den turm von dem eigenen guthaben ab
	
	Klickt der spieler auf den turm-button, wird eine instanz des zauber-turms erzeugt. dieser turm bewegt sich mit der maus, bis ein linksklick betätigt wird.
	mit einem rechtsklick wird die option abgebrochen
	*/
public class initiateWandTower : MonoBehaviour {

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

	//Instanziiert die Geldanzeige
	void Start () {
		moneyScript = currentMoneyText.GetComponent<CurrentMoneyAttributes> ();
		currentMoney = moneyScript.GetCurrentMoney();
		hold = false;
		currentMoneyString = currentMoneyText.GetComponent<Text> ();
		currentMoneyString.text = " " + currentMoney; 
	}

	// hier wird die maus-aktion des spielers überwacht und eine klick auf den button verwaltet
	void Update () {
		//der spieler hat den turm-knopf gedrückt und einen ungesetzten turm, der seiner maus folgt
		if (hold) {
			obj.transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 1));
		}
		//der spieler klickt die linke maustaste auf dem turm button
		if (Input.GetMouseButtonDown (0)) {
			currentMoney = moneyScript.GetCurrentMoney();
			
			//hier wird abgefragt, ob der spieler sich den turm leisten kann
			if (hold && currentMoney >= cost) {
				currentMoney -= cost; 
				currentMoneyString.text = " " + currentMoney; 
				hold = false;
				//moneyScript.setCurrentMoney(currentMoney);
				GameObject.Find ("PlayerHome").SendMessage("setMoney", currentMoney, SendMessageOptions.RequireReceiver);
			} 
			//der spieler kann sich den turm nicht leisten, somit wird er nicht gesetzt
			else if (currentMoney < cost) {
				Debug.Log ("Not enough money!");
			}
		} 
		//die rechte maustaste wird betätigt. sollte der spieler gerade einen turm halten, wird dieser gelöscht
		else if (Input.GetMouseButtonDown (1)) {
			if (hold) {
				Destroy (obj);
				hold = false;
			}
		}
	}

	//diese funktion instantiiert den turm und den bedingungen, dass der spieler den turm-button drückt 
	public void InstantiateWandTower(){
		hold = true;
		mousePosX = Input.mousePosition.x;
		mousePosY = Input.mousePosition.y;
		var objectPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePosX, mousePosY, 1));
		obj = Instantiate (prefab, objectPos, Quaternion.identity) as GameObject;
	}
}
