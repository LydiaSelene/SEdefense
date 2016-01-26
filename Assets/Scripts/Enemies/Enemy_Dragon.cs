using UnityEngine;
using System.Collections;

public class Enemy_Dragon : MonoBehaviour {

	Transform thistransform;
	public int health;
	public float movingSpeed;
	Vector3 movingDirection;

	// Use this for initialization
	void Start () {
		thistransform = transform;
		health = 10;
		movingSpeed = 8.0f;

		movingDirection = new Vector3 (-1, 0, 0);
	}
		
	// Update is called once per frame
	void Update () {
		thistransform.Translate (movingDirection*movingSpeed*Time.deltaTime, Space.World);
	}

	public void onDespawn(){
		//TODO: Leben vom Spieler abziehen
		Destroy (gameObject);
	}

	public void onDeath(){
		Debug.Log("tot");
		Destroy (gameObject);
	}
}
