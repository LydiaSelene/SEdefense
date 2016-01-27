using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy_Dragon : MonoBehaviour {

	Transform thistransform;
	float health;
	float movingSpeed;
	Vector3 targetPoint;
	Vector3 movingDirection;
	//List<Vector3> waypoints;
	List<Vector3> waypoints;
	int wayPointNumber;

	// Use this for initialization
	void Start () {
		thistransform = transform;
		health = 10;
		movingSpeed = 7.0f;
		targetPoint = transform.position;
	}

	public void setWaypoints(List<Vector3> list){
		waypoints = list;
		wayPointNumber = 0;
	}

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

	public void dealDamage(float amount){
		health -= amount;
		if(health <= 0){
			onDeath ();
		}
	}

	public void onDeath(){
		Destroy (gameObject);
	}

	public void onDespawn(){
		//TODO: Leben vom Spieler abziehen
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {

		if(Vector3.Distance(thistransform.position, targetPoint) < 0.15f){
			setNextWaypoint ();
		}
		movingDirection = targetPoint - thistransform.position;
		thistransform.Translate (movingDirection.normalized*movingSpeed*Time.deltaTime, Space.World);
	}


	public float getMovingSpeed(){
		return movingSpeed;
	}

	public Vector3 getMovingDirection(){
		return movingDirection;
	}

}
