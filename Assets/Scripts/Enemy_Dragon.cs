using UnityEngine;
using System.Collections;

public class Enemy_Dragon : MonoBehaviour {

	Transform thistransform;
	public int health;
	public float movingSpeed;

	// Use this for initialization
	void Start () {
		thistransform = transform;
		health = 10;
		movingSpeed = 0.15f;
	}
	
	// Update is called once per frame
	void Update () {
		thistransform.Translate (new Vector3 (-movingSpeed, 0, 0));
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
