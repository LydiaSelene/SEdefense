using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy_Santa : MonoBehaviour {

	//Das Transformobjekt, nur lokal wegen Performance
	Transform thistransform;
	//Das Leben des Gegners
	float health;
	//Die Geschwindigkeit, mit der sich der Gegner bewegt
	float movingSpeed;
	//Die aktuelle Zielposition des Gegners
	Vector3 targetPoint;
	//Der aktuelle Bewegungsvektor vom Gegner zum Zielpunkt
	Vector3 movingDirection;
	//Alle Wegpunkte, die der Gegner abgehen soll
	List<Vector3> waypoints;
	//Die WegpunktNummer für den nächsten Wegpunkt
	int wayPointNumber;
	//Geld, das der Gegner beim Tod gibt
	int money;

	// Use this for initialization
	void Start () {
		thistransform = transform;
		health = 160f;
		movingSpeed = 6.6f;
		targetPoint = transform.position;
		money = 200;
	}

	//Der Gegner erhält alle Wegpunkte, die er abgehen soll.
	public void setWaypoints(List<Vector3> list){
		waypoints = list;
		wayPointNumber = 0;
		targetPoint = transform.position;
		movingDirection = Vector3.zero;
	}

	//Setzt die nächste Position, zu der sich der Gegner bewegt.
	void setNextWaypoint(){
		//Debug.Log ("wayPointNumber " + wayPointNumber);
		if (wayPointNumber < waypoints.Count) {
			targetPoint = waypoints [wayPointNumber];
			//Debug.Log ("targetPoint " + targetPoint);
			wayPointNumber += 1;
			//waypoints.RemoveAt (0);
		} else {
			targetPoint = thistransform.position;
			movingDirection = Vector3.zero;
		}
	}

	//Der Gegner erleidet Schaden
	public void dealDamage(float amount){
		health -= amount;
		if(health <= 0){
			onDeath ();
		}
	}

	//Wenn der Gegner stirt
	public void onDeath(){
		Destroy (gameObject);
		GameObject.Find ("PlayerHome").SendMessage("giveMoneyFromKilledEnemy", money, SendMessageOptions.RequireReceiver);
	}

	//Soll aufgerufen werden, wenn der Gegner seinen eigentlichen Zielort erreicht
	public void onDespawn(){
		//TODO: Leben vom Spieler abziehen
		Destroy (gameObject);
	}

	//dreht bei bewegung in negative X-Richtung das Sprite um
	void checkMovingDirectionX(){
		if(movingDirection.x <= 0 && thistransform.localScale.x > 0){
			Vector3 sc = thistransform.localScale;
			sc.x *= (-1);
			thistransform.localScale = sc;
		}else if(movingDirection.x >= 0 && thistransform.localScale.x < 0){
			Vector3 sc = thistransform.localScale;
			sc.x *= (-1);
			thistransform.localScale = sc;
		}
	}

	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (thistransform.position, targetPoint) < 0.15f) {
			setNextWaypoint ();
		} else {
			movingDirection = targetPoint - thistransform.position;
			//Debug.Log ("movingDirection.x "+movingDirection.x);
			checkMovingDirectionX ();

			thistransform.Translate (movingDirection.normalized*movingSpeed*Time.deltaTime, Space.World);
		}
	}


	public float getMovingSpeed(){
		return movingSpeed;
	}

	public Vector3 getMovingDirection(){
		return movingDirection;
	}

	public int getMoney(){
		return money;
	}

}
