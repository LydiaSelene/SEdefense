using UnityEngine;
using System.Collections;

public class Enemy_Dragon : MonoBehaviour {

	Transform thistransform;
	float health;
	float movingSpeed;
	Vector3 movingDirection;

	// Use this for initialization
	void Start () {
		thistransform = transform;
		health = 10;
		movingSpeed = 7.0f;

		movingDirection = new Vector3 (-1, 0, 0);
	}

	public void dealDamage(float amount){
		health -= amount;
		if(health <= 0){
			onDeath ();
		}
	}

	public void onDeath(){
		Debug.Log("tot");
		Destroy (gameObject);
	}

	public void onDespawn(){
		//TODO: Leben vom Spieler abziehen
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		thistransform.Translate (movingDirection*movingSpeed*Time.deltaTime, Space.World);
	}


	public float getMovingSpeed(){
		return movingSpeed;
	}

	public Vector3 getMovingDirection(){
		return movingDirection;
	}

}
